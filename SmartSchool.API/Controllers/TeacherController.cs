using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {

        private readonly SmartContext _context;

        public TeacherController(SmartContext context)
        {
            _context = context;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Teachers);
        }

        // GET api/<TeacherController>/5
        [HttpGet("ById/{id}")]
        public IActionResult Get(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(T => T.Id == id);
            if (teacher == null)
            {
                return BadRequest("Teacher not found!");
            }
            return Ok(teacher);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public IActionResult Post(Teacher teacher)
        {
            _context.Add(teacher);
            _context.SaveChanges();
            return Ok("Teacher added successfully");
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Teacher teacher)
        {
            var _teacher = _context.Teachers.AsNoTracking().FirstOrDefault(T => T.Id == id);
            if (_teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _context.Update(teacher);
            _context.SaveChanges();
            return Ok("Teacher data updated successfully!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Teacher teacher)
        {
            var _teacher = _context.Teachers.AsNoTracking().FirstOrDefault(T => T.Id == id);
            if (_teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _context.Update(teacher);
            _context.SaveChanges();
            return Ok("Teacher updated successfully!");
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(T => T.Id == id);
            if (teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _context.Remove(teacher);
            _context.SaveChanges();
            return Ok("Teacher deleted!");
        }
    }
}
