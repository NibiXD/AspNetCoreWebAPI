using System;

namespace SmartSchool.API.Models
{
    public class StudentCourse
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public int? Grade { get; set; } = null;
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public StudentCourse()
        {
        }

        public StudentCourse(int studentId, int courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }
    }
}
