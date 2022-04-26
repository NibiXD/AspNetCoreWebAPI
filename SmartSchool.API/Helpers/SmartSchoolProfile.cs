using AutoMapper;
using SmartSchool.API.Dtos;
using SmartSchool.API.Models;

namespace SmartSchool.API.Helpers
{
    public class SmartSchoolProfile : Profile
    {
        public SmartSchoolProfile()
        {
            CreateMap<Student, StudentDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.Name} {src.Surname}")
                )
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.BirthDate.GetCurrentAge())
                );

            CreateMap<StudentDto, Student>();
            CreateMap<Student, StudentRegisterDto>().ReverseMap();

            CreateMap<Teacher, TeacherDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.Name} {src.Surname}")
                );

            CreateMap<TeacherDto, Teacher>();
            CreateMap<Teacher, TeacherRegisterDto>().ReverseMap();
        }
    }
}
