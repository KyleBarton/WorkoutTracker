using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Repositories;

namespace WorkoutTracker.Domain.UnitTests.Mocks {
    public class InMemoryUserWorkoutRepository : IUserWorkoutRepository
    {
        private List<Workout> _entities;

        public InMemoryUserWorkoutRepository(){
            _entities = new List<Workout>();
        }
        public Task<Workout> CreateNew()
        {
            throw new System.NotImplementedException();
        }

        public Task<Workout> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Workout>> GetPaged(PageInfo pageInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}