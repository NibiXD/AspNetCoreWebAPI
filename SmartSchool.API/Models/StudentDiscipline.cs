namespace SmartSchool.API.Models
{
    public class StudentDiscipline
    {
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
