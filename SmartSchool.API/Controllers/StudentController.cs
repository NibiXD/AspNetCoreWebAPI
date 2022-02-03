using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repository;

        public StudentController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repository.GetAllStudents(true);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _repository.GetStudentById(id, true);
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
            _repository.Add(student);
            if (_repository.SaveChanges())
            {
                return Ok(student);
            }
            return BadRequest("Student not registered");
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            var _student = _repository.GetStudentById(id, false);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _repository.Update(student);
            if (_repository.SaveChanges())
            {
                return Ok(student);
            }
            return BadRequest("Student not registered");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Student student)
        {
            var _student = _repository.GetStudentById(id, false);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _repository.Update(student);
            if (_repository.SaveChanges())
            {
                return Ok(student);
            }
            return BadRequest("Student not registered");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _student = _repository.GetStudentById(id, false);
            if (_student == null)
            {
                return BadRequest("Student not found!");
            }

            _repository.Delete(_student);
            if (_repository.SaveChanges())
            {
                return Ok("Student deleted");
            }
            return BadRequest("Student not registered");
        }

        
    }
}
