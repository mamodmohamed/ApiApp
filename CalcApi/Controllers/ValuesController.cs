using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCalcClassLibrary;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Calc calc = new Calc();
        // GET: api/<ValuesController>
        [HttpGet("/average")]

        public int Average([FromQuery]int[]nums)
        {
            return calc.Average(nums);

        }
        [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {

            return calc.Smallest(nums);
        }
        [HttpGet("/largest")]
        public int Largest([FromQuery] int[] nums)
        {
            return calc.Largest(nums);

        }


    }
}
