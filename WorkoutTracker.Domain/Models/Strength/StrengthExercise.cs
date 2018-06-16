using System.Collections.Generic;

namespace WorkoutTracker.Domain.Strength
{
    public class StrengthExercise
    {
        private readonly List<StrengthSet> _sets;
        private readonly StrengthMove _strengthMove;
        private readonly int _exerciseId;

        public StrengthExercise(StrengthMove strengthMove){
            _sets = new List<StrengthSet>();
            _strengthMove = strengthMove;
            _exerciseId = 111; /// stubbed
        }
        public int ExerciseId {
            get {
                return _exerciseId;
            }
        }
        public StrengthMove StrengthMove {get
            {
                return _strengthMove;
            }
        }
        public List<StrengthSet> Sets {
            get {
                return _sets;
            }
        }
        public void AddSet(StrengthSet set) => Sets.Add(set);
    }
}
