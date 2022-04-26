using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }

        public Course()
        {
        }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
