using System.Collections.Generic;
using WorkoutTracker.Domain.Models;

namespace WorkoutTracker.Domain {
    public interface IUserExerciseProvider {
        IEnumerable<Exercise> GetAll();
        Exercise GetById(int id);

        Exercise AddNew(Exercise request);
    }
}