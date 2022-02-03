using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repository;

        public TeacherController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAllTeachers(true));
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var teacher = _repository.GetTeacherById(id, true);
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
            _repository.Add(teacher);
            if (_repository.SaveChanges())
            {
                return Ok(teacher);
            }
            return BadRequest("Teacher not found!");
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Teacher teacher)
        {
            var _teacher = _repository.GetTeacherById(id, false);
            if (_teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _repository.Update(teacher);
            if (_repository.SaveChanges())
            {
                return Ok(teacher);
            }
            return BadRequest("Teacher not found!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Teacher teacher)
        {
            var _teacher = _repository.GetTeacherById(id, false);
            if (_teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _repository.Update(teacher);
            if (_repository.SaveChanges())
            {
                return Ok(teacher);
            }
            return BadRequest("Teacher not found!");
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _repository.GetTeacherById(id, false);
            if (teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _repository.Delete(teacher);
            if (_repository.SaveChanges())
            {
                return Ok("Teacher deleted!");
            }
            return BadRequest("Teacher not found!");
        }
    }
}
