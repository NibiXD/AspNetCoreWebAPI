using Microsoft.AspNetCore.Mvc;
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
        List<Student> students = new List<Student>
        {
            new Student(1, "Daniel", "Carlos", "84849595"),
            new Student(2, "Jorge", "Dias", "95958484"),
            new Student(3, "Ney", "Vitu", "95958585")
        };

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(students);
        }

        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id.Equals(id));
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
            return Ok(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            return Ok(student);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        
    }
}
