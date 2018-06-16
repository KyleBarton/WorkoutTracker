using System.Collections.Generic;

namespace WorkoutTracker.Domain.Strength
{
    //TODO: pull out generic strategies if possible
    public class StrengthWorkout
    {
        private readonly List<StrengthExercise> _exercises;
        private readonly int _workoutId;

        public StrengthWorkout(){
            _workoutId = 111; /// stubbed
            _exercises = new List<StrengthExercise>();
        }
        public int WorkoutId {
            get {
                return _workoutId;
            }
        }

        public IEnumerable<StrengthExercise> Exercises {
            get {
                return _exercises;
            }
        }
        public void AddExercise(StrengthExercise exercise){
            _exercises.Add(exercise);
        }
    }
}
