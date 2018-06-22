using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Repositories;

namespace WorkoutTracker.DataAccess.Mongo {

    public class UserWorkoutRepository : IUserWorkoutRepository
    {
        public UserWorkoutRepository(){
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("WorkoutTracker");
            var userWorkoutsCollection = db.GetCollection<Workout>("Workouts");
        }
        public Task<Workout> CreateNew()
        {
            throw new System.NotImplementedException();
        }

        public Task<Workout> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Workout>> GetPaged(PageInfo pageInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}