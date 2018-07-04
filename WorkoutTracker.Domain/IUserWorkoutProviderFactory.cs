namespace WorkoutTracker.Domain {
    public interface IUserWorkoutProviderFactory {
        IUserWorkoutProvider GetForUser(int userId);

    }
}