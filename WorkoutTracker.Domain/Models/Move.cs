using System.Collections.Generic;

namespace WorkoutTracker.Domain.Models
{
    public class Move
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<ExerciseCategory> Categories {get;set;}
    }
}