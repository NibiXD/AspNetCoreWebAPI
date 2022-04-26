using System.Collections.Generic;

namespace SmartSchool.API.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Workload { get; set; }
        public int? PreRequisiteId { get; set; } = null;
        public Discipline PreRequisite { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }

        public Discipline()
        {
        }

        public Discipline(int id, string name, int teacherId, int courseId)
        {
            Id = id;
            Name = name;
            TeacherId = teacherId;
            CourseId = courseId;
        }
    }
}
