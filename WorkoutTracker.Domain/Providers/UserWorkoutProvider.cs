using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Strength;

namespace WorkoutTracker.Domain.Providers{
    public class UserWorkoutProvider : IUserWorkoutProvider
    {
        private readonly int _userId;

        public UserWorkoutProvider(){
            //TODO inject with some sort of provider
            _userId = 1;
        }

        public async Task<Workout> AddNew()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Workout>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Workout> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}