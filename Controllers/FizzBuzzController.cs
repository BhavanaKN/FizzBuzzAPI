using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzAPI.FizzBuzzData;
using FizzBuzzAPI.Models;

namespace FizzBuzzAPI.Controllers
{
    
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private IFizzBuzzData _fizzBuzzData;
        public FizzBuzzController(IFizzBuzzData fizzBuzzData)
        {
            _fizzBuzzData = fizzBuzzData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetFizzBuzzData()
        {

            var fizzBuzz= _fizzBuzzData.GetFizzBuzzData();

            if (fizzBuzz != null)
            {
                return Ok(fizzBuzz);
            }
            return NotFound("fizzBuzz Data not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddFizzBuzzData()
        {
            var fizzBuzz = _fizzBuzzData.GetFizzBuzzData();

            if (fizzBuzz.Count > 0)
            {
                return Ok(fizzBuzz);
            }
            else
            {
                _fizzBuzzData.AddFizzBuzzData();
                return Ok();
            }
            /*return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + fizzBuzz.id,
                fizzBuzz);*/
        }
    }
}