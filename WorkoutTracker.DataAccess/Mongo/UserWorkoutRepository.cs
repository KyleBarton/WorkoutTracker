using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using WorkoutTracker.Domain.Models;
using WorkoutTracker.Domain.Repositories;

namespace WorkoutTracker.DataAccess.Mongo {

    public class UserWorkoutRepository : IUserWorkoutRepository
    {
        private readonly IMongoCollection<Workout> _userWorkoutsCollection;

        public UserWorkoutRepository(){
            var client = new MongoClient("mongodb://10.0.0.97:27017");
            var db = client.GetDatabase("WorkoutTracker");
            _userWorkoutsCollection = db.GetCollection<Workout>("Workouts");
        }
        public async Task<Workout> CreateNew(Workout workout)
        {
            var workoutCount = await _userWorkoutsCollection.CountAsync(new BsonDocument());
            workout.Id = (int)workoutCount + 1;
            await _userWorkoutsCollection.InsertOneAsync(workout);
            return workout;
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