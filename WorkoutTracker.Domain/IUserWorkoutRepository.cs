using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;

namespace WorkoutTracker.Domain.Repositories
{
    public interface IUserWorkoutRepository
    {
        Task<Workout> CreateNew();
        Task<Workout> GetById(int id);
        Task<IEnumerable<Workout>> GetPaged(PageInfo pageInfo);
    }
}