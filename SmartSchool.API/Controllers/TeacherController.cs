using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using SmartSchool.API.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public TeacherController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public IActionResult Get()
        {
            var teachers = _repository.GetAllTeachers(true);
            var result = _mapper.Map<IEnumerable<TeacherDto>>(teachers);

            return Ok(result);
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var teachers = _repository.GetTeacherById(id, true);
            var result = _mapper.Map<TeacherDto>(teachers);

            if (teachers == null)
            {
                return BadRequest("Teacher not found!");
            }
            return Ok(result);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public IActionResult Post(TeacherRegisterDto model)
        {
            var teacher = _mapper.Map<Teacher>(model);

            _repository.Add(teacher);
            if (_repository.SaveChanges())
            {
                return Created($"api/Teacher/{model.Id}", _mapper.Map<TeacherDto>(teacher));
            }
            return BadRequest("Teacher not found!");
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, TeacherRegisterDto model)
        {
            var teacher = _repository.GetTeacherById(id, false);
            if (teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _mapper.Map(model, teacher);

            _repository.Update(teacher);
            if (_repository.SaveChanges())
            {
                return Created($"api/Teacher/{model.Id}", _mapper.Map<TeacherDto>(teacher));
            }
            return BadRequest("Teacher not found!");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, TeacherRegisterDto model)
        {
            var teacher = _repository.GetTeacherById(id, false);
            if (teacher == null)
            {
                return BadRequest("Teacher not found!");
            }

            _mapper.Map(model, teacher);

            _repository.Update(teacher);
            if (_repository.SaveChanges())
            {
                return Created($"api/Teacher/{model.Id}", _mapper.Map<TeacherDto>(teacher));
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
