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

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var job = _context.Job.Where(_ => _.Id == id).FirstOrDefault();
            return Ok(job);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Job job)
        {
            try
            {
                _context.Job.Add(job);
                _context.SaveChanges();

                return Created($"/jobs/{job.Id}", job);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromQuery] string name)
        {
            try
            {
                var job = _context.Job.Where(_ => _.Id == id).FirstOrDefault();
                job.Name = name;
                _context.SaveChanges();

                return Ok("Job updated.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var job = _context.Job.Where(_ => _.Id == id).FirstOrDefault();
                _context.Remove(job);
                _context.SaveChanges();

                return Ok("Job deleted.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
