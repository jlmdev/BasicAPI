using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        // Inside the ( ) goes a string. Inside the string is any additional parts of the url
        //  past /api/dice that we want. In this case we trite {sides} to say take whatever the user
        // Provides after the last / parse it as an integer 
        [HttpGet("{sides}")]
        public List<int> Roll(int sides, int count = 1)
        {
            var rolls = new List<int>();
            var randomNumberGenerator = new Random();
            for (var rollNumber = 0; rollNumber < count; rollNumber++)
            {
                var roll = randomNumberGenerator.Next(sides) + 1;
                rolls.Add(roll);
            }
            return rolls;
        }
    }
}