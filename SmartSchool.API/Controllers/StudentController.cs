using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Dtos;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public StudentController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            var students = _repository.GetAllStudents(true);
            var result = _mapper.Map<IEnumerable<StudentDto>>(students);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _repository.GetStudentById(id, true);
            var studentDto = _mapper.Map<StudentDto>(student);

            if (student == null)
            {
                return BadRequest("Student id doesn't exist!");
            }
            return Ok(studentDto);
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post(StudentRegisterDto model)
        {
            var student = _mapper.Map<Student>(model);

            _repository.Add(student);
            if (_repository.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<StudentDto>(student));
            }
            return BadRequest("Student not registered");
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, StudentRegisterDto model)
        {
            var student = _repository.GetStudentById(id, false);
            if (student == null)
            {
                return BadRequest("Student not found!");
            }

            _mapper.Map(model, student);

            _repository.Update(student);
            if (_repository.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<StudentDto>(student));
            }
            return BadRequest("Student not registered");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, StudentRegisterDto model)
        {
            var student = _repository.GetStudentById(id, false);
            if (student == null)
            {
                return BadRequest("Student not found!");
            }

            _mapper.Map(model, student);

            _repository.Update(student);
            if (_repository.SaveChanges())
            {
                return Created($"/api/aluno/{model.Id}", _mapper.Map<StudentDto>(student));
            }
            return BadRequest("Student not registered");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _repository.GetStudentById(id, false);
            if (student == null)
            {
                return BadRequest("Student not found!");
            }

            _repository.Delete(student);
            if (_repository.SaveChanges())
            {
                return Ok("Student deleted");
            }
            return BadRequest("Student not registered");
        }

        
    }
}
