using System;

namespace SmartSchool.API.Models
{
    public class StudentDiscipline
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public int? Grade { get; set; } = null;
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }

        public StudentDiscipline()
        {
        }

        public StudentDiscipline(int studentId, int disciplineId)
        {
            StudentId = studentId;
            DisciplineId = disciplineId;
        }
    }
}
