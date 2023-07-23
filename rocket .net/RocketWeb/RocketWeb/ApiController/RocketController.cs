using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RocketWeb.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RocketWeb.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RocketController : ControllerBase
    {

        // POST api/<RocketController>
        [HttpPost]
        public Rocket Post(Rocket rocket)
        {
            Console.WriteLine(JsonSerializer.Serialize(rocket));
            return rocket;
        }

    }
}
