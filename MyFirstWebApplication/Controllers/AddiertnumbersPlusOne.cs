﻿using Microsoft.AspNetCore.Mvc;
using Rest_API.Controllers;
using Rest_API.Controllers.Rest_API.Models;

namespace Rest_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Addiert1zuInput : Controller
    {
        [HttpPut("{number}")]
        public IActionResult Numberadding(int number)
        {
            int numberplusone = number + 1;
            return Ok(numberplusone);
        }
    }

    [Route("api/sumOfInputs")]
    [ApiController]
    public class SumOfInputsController : ControllerBase
    {
        [HttpPut("sumOfNumbers")]
        public IActionResult SumOfNumbers([FromBody] SumRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid input.");
            }

            int result = request.Input1 + request.Input2;
            return Ok(result);
        }
    }


    namespace Rest_API.Models
    {
        public class SumRequest
        {
            public int Input1 { get; set; }
            public int Input2 { get; set; }
        }
    }
}


