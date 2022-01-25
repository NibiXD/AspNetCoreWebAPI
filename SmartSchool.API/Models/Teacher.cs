using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }

        public Teacher()
        {
        }

        public Teacher(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
