using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using WorkoutTracker.Domain.Providers;

namespace WorkoutTracker.Domain.UnitTests
{
    public class UserWorkoutProviderTests {
        private const int UserId = 12321;
        private UserWorkoutProvider _workoutProvider;

        [SetUp]
        public void Setup(){
            _workoutProvider = new UserWorkoutProvider(UserId);

        }

        // [Test]
        // public async Task Should_Be_Able_To_Successfully_Add_New_Workout(){
        //     var newWorkout = await _workoutProvider.AddNew();

        // }
        //
        //Should_Be_Able_To_Retrieve_All_Workouts
        //Should_Be_Able_To_Get_Workout_By_Id
    }
    
}