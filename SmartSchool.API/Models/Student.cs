using System;
using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Registration { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
        public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }

        public Student()
        {
        }

        public Student(int id, int registration, string name, string surname, string phoneNumber, DateTime birthDate)
        {
            Id = id;
            Registration = registration;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }
    }
}
