using WorkoutTracker.Domain.Providers;
using WorkoutTracker.Domain.Repositories;

namespace WorkoutTracker.Domain.Factories {
    public class UserWorkoutProviderFactory : IUserWorkoutProviderFactory
    {
        private readonly IUserWorkoutRepository _userWorkoutRepository;

        public UserWorkoutProviderFactory(IUserWorkoutRepository userWorkoutRepository){
            _userWorkoutRepository = userWorkoutRepository;
        }
        public IUserWorkoutProvider GetForUser(int userId)
        {
            return new UserWorkoutProvider(userId, _userWorkoutRepository);
        }
    }
}