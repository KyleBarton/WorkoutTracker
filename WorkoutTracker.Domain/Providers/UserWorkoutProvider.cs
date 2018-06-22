using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Repositories;
using WorkoutTracker.Domain.Strength;

namespace WorkoutTracker.Domain.Providers
{
    public class UserWorkoutProvider : IUserWorkoutProvider
    {
        public IUserWorkoutRepository _repository { get; }

        private readonly int _userId;

        public UserWorkoutProvider(int userId, IUserWorkoutRepository repository){
            _repository = repository;
            _userId = userId;
        }

        //TODO add async naming convention
        public async Task<Workout> AddNew()
        {
            return await _repository.CreateNew();
        }

        public async Task<IEnumerable<Workout>> GetAll(PageInfo pageInfo)
        {
            return await _repository.GetPaged(pageInfo);
        }

        public async Task<Workout> GetById(int id)
        {
            return await _repository.GetById(id);
        }
    }
}