namespace WorkoutTracker.Domain.Strength
{
    public class StrengthSet
    {
        public StrengthSet(int reps, int weightlbs){
            Reps = reps;
            WeightLbs = weightlbs;
        }
        public int Reps {get; private set;}
        public int WeightLbs {get; private set;}
        public void AddRep(){
            Reps++;
        }
        public void EditWeight(int newWeight){
            WeightLbs = newWeight;
        }
    }
}
