using System.Threading.Tasks;
using WorkoutTracker.Domain.Models;

namespace WorkoutTracker.Domain.Providers
{
    public interface IUserWorkoutRepository
    {
        Task<Workout> CreateNew();
        Task<Workout> GetById(int id);
    }
}