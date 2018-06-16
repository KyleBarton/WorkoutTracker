using System.Collections.Generic;

namespace WorkoutTracker.Domain.Models
{
    public class Exercise
    {
        public int Id {get;set;}
        public List<MoveSet> Sets {get;set;}
    }
}