using System.Collections.Generic;
using WorkoutTracker.Domain.Strength;

namespace WorkoutTracker.Domain {
    public interface IUserWorkoutProvider {
        IEnumerable<StrengthWorkout> GetAll();
        StrengthWorkout GetById(int id);
    }
}