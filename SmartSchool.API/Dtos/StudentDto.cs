using System;

namespace SmartSchool.API.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public int Registration { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
    }
}
