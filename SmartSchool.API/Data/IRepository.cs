using SmartSchool.API.Models;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();
        Student[] GetAllStudents(bool includeTeacher = false);
        Student[] GetAllStudentsByDisciplineId(int disciplineId, bool includeTeacher);
        Student GetStudentById(int id, bool includeTeacher);
        Teacher[] GetAllTeachers(bool includeStudent);
        Teacher[] GetAllTeachersByDisciplineId(int disciplineId, bool includeStudent);
        Teacher GetTeacherById(int id, bool includeStudent);

    }
}
