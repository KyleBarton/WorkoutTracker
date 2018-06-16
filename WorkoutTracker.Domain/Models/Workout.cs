using System.Collections.Generic;

namespace WorkoutTracker.Domain.Models {
    public class Workout {
        public int Id {get;set;}
        public List<Exercise> Exercises {get; set;}
    }
}