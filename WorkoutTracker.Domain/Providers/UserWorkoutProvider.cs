using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Strength;

namespace WorkoutTracker.Domain.Providers{
    public class UserWorkoutProvider : IUserWorkoutProvider
    {
        private readonly int _userId;

        public UserWorkoutProvider(int userId){
            //TODO inject with some sort of provider
            _userId = userId;
        }

        //TODO add async naming convention
        public async Task<Workout> AddNew()
        {
            return new Workout {
                Status = WorkoutStatus.New
            };
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