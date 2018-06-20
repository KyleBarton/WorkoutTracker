using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Providers;
using Moq;

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
    }
}