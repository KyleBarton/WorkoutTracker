using System;
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
        private readonly IUserWorkoutProviderFactory _workoutProviderFactory;

        public UserWorkoutsController(IUserWorkoutProviderFactory workoutProviderFactory){
            _workoutProviderFactory = workoutProviderFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var workoutProvider = _workoutProviderFactory.GetForUser(GetUserId());
            //todo page
            return Ok(await workoutProvider.GetAll(new PageInfo(1, 10)));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var workoutProvider = _workoutProviderFactory.GetForUser(GetUserId());
            return Ok(await workoutProvider.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddWorkoutRequest workoutRequest)
        {
            var userId = GetUserId();
            var workoutProvider = _workoutProviderFactory.GetForUser(GetUserId());
            var createdWorkout = await workoutProvider.AddNew();
            return Ok(createdWorkout);
        }

        private int GetUserId()
        {
            return 1;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return BadRequest("We do not currently support workout deletions");
        }
    }
}
