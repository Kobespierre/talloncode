using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalFantasyAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FinalFantasyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : AppController
    {
        public JobsController(FF_DbContext context) : base(context) { }
        [HttpGet]
        public IActionResult Get()
        {
            var jobs = _context.Job.ToList();
            return Ok(jobs);
        }
    }
}
