using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Api.Contracts;
using WorkoutTracker.Domain;
using WorkoutTracker.Domain.Models;

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
        public async Task<IActionResult> Get()
        {
            //todo page
            return Ok(await _workoutProvider.GetAll(new PageInfo(1, 10)));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _workoutProvider.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddWorkoutRequest workoutRequest)
        {
            var createdWorkout = await _workoutProvider.AddNew();
            return Ok("Yeah, sure I made a new one");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return BadRequest("We do not currently support workout deletions");
        }
    }
}
