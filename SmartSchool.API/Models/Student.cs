﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, string surname, string phoneNumber)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}