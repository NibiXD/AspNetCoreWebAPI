using System;

namespace SmartSchool.API.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public int Registration { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
    }
}
