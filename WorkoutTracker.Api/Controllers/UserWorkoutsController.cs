using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.Contracts;
using WorkoutTracker.Domain;

namespace WorkoutTracker.Api.Controllers
{
    [Route("api/user/workouts")]
    public class UserWorkoutsController : Controller
    {
        private readonly IUserWorkoutProvider _workoutProvider;

        public UserWorkoutsController(IUserWorkoutProvider workoutProvider){
            _workoutProvider = workoutProvider;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //todo page
            return Ok(_workoutProvider.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_workoutProvider.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]AddWorkoutRequest workoutRequest)
        {
            return Ok("Yeah, sure I made a new one");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("YOU'RE FIRED");
        }
    }
}
