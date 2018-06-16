using System.Collections.Generic;

namespace WorkoutTracker.Domain.Models
{
    public class MoveSet
    {
        public Move Move {get;set;}
        public List<Repetition> Repetition {get;set;}
    }
}