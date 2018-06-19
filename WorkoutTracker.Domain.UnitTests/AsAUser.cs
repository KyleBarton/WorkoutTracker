using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Providers;

namespace WorkoutTracker.Domain.UnitTests
{
    public class AsAUser {
        private const int UserId = 12321;
        private UserWorkoutProvider _workoutProvider;

        [SetUp]
        public void Setup(){
            _workoutProvider = new UserWorkoutProvider(UserId);

        }

        [Test]
        public async Task I_Should_Be_Able_To_Start_A_Workout(){
            var newWorkout = await _workoutProvider.AddNew();
            newWorkout.Status.Should().Be(WorkoutStatus.New);
        }
        //I_Should_Be_Able_To_Retrieve_My_New_Workout
        //
        //
    }
    
}