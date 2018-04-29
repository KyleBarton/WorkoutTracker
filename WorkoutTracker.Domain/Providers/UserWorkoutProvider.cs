using System.Collections.Generic;
using WorkoutTracker.Domain.Strength;

namespace WorkoutTracker.Domain.Providers{
    public class UserWorkoutProvider : IUserWorkoutProvider
    {
        private readonly int _userId;

        public UserWorkoutProvider(){
            //TODO inject with some sort of provider
            _userId = 1;
        }
        public IEnumerable<StrengthWorkout> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public StrengthWorkout GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}