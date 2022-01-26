using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SmartContext _context;

        public StudentController(SmartContext context)
        {
            _context = context;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Students);
        }

        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id.Equals(id));
            if (student == null)
            {
                return BadRequest("Student id doesn't exist!");
            }
            return Ok(student);
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            var _student = _context.Students.AsNoTracking().FirstOrDefault(s => s.Id == id);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _context.Update(student);
            _context.SaveChanges();
            return Ok(student);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            var _student = _context.Students.AsNoTracking().FirstOrDefault(s => s.Id == id);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _context.Update(student);
            _context.SaveChanges();
            return Ok(student);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _context.Remove(_student);
            _context.SaveChanges();
            return Ok("Student deleted!");
        }

        
    }
}
