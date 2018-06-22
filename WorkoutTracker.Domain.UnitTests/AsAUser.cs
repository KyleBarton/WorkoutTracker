using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Providers;
using Moq;
using System.Collections.Generic;
using WorkoutTracker.Domain.Repositories;

namespace WorkoutTracker.Domain.UnitTests
{
    public class AsAUser {
        private const int UserId = 12321;
        private const int RandomUserWorkoutId = 43255;
        private Mock<IUserWorkoutRepository> _mockRepository;
        private UserWorkoutProvider _workoutProvider;

        [SetUp]
        public void Setup(){
            _mockRepository = new Mock<IUserWorkoutRepository>();
            _workoutProvider = new UserWorkoutProvider(UserId, _mockRepository.Object);

            _mockRepository.Setup(r => r.CreateNew()).ReturnsAsync(new Workout {
                    Id = RandomUserWorkoutId,
                    Status = WorkoutStatus.New
            });

            _mockRepository.Setup(r => r.GetById(RandomUserWorkoutId)).ReturnsAsync(new Workout {
                Id = RandomUserWorkoutId,
                Status = WorkoutStatus.New
            });
        }

        [Test]
        public async Task I_Should_Be_Able_To_Start_A_New_Workout(){

            var newWorkout = await _workoutProvider.AddNew();

            var workoutRetrieved = await _workoutProvider.GetById(newWorkout.Id);

            workoutRetrieved.Should().BeEquivalentTo(newWorkout);
            newWorkout.Status.Should().Be(WorkoutStatus.New);
        }

        [Test]
        public async Task I_Should_Be_Able_To_Get_My_Workouts(){
            List<Workout> expectedWorkouts = new List<Workout> {
               new Workout{
                   Id = 1,
                   Status = WorkoutStatus.New
               },
               new Workout{
                   Id = 2,
                   Status = WorkoutStatus.New
               }
           };
            _mockRepository.Setup(r => r.GetPaged(It.IsAny<PageInfo>())).ReturnsAsync(expectedWorkouts);

            (await _workoutProvider.GetAll(new PageInfo(1, 10))).Should().BeEquivalentTo(expectedWorkouts);
        }
    }
}