using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WorkoutTracker.Api.Controllers
{
    [Route("")]
    public class HealthCheckController : Controller
    {
        //This is so that a load balancer can run a cheap healthceck against this service
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}