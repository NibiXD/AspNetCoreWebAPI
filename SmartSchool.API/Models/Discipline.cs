using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }

        public Discipline()
        {
        }

        public Discipline(int id, string name, int teacherId)
        {
            Id = id;
            Name = name;
            TeacherId = teacherId;
        }
    }
}
