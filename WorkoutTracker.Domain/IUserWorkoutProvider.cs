using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;

namespace WorkoutTracker.Domain {
    public interface IUserWorkoutProvider {
        Task<IEnumerable<Workout>> GetAll(PageInfo pageInfo);
        Task<Workout> GetById(int id);

        Task<Workout> AddNew();
    }
}