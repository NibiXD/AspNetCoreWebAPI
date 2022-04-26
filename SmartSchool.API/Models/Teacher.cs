using System.Collections.Generic;
using System;

namespace SmartSchool.API.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int Registration { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
        public IEnumerable<Discipline> Disciplines { get; set; }

        public Teacher()
        {
        }

        public Teacher(int id, int registration, string name, string surname)
        {
            Id = id;
            Registration = registration;
            Name = name;
            Surname = surname;
        }
    }
}
