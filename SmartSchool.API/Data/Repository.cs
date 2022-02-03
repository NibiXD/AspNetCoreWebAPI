using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Linq;

namespace SmartSchool.API.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;

        public Repository(SmartContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Student[] GetAllStudents(bool includeTeacher = false)
        {
            IQueryable<Student> query = _context.Students;

            if (includeTeacher)
            {
                query = query.Include(s => s.StudentsDisciplines)
                        .ThenInclude(sd => sd.Discipline)
                        .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking().OrderBy(s => s.Id);
            return query.ToArray();
        }

        public Student[] GetAllStudentsByDisciplineId(int disciplineId, bool includeTeacher)
        {
            IQueryable<Student> query = _context.Students;

            if (includeTeacher)
            {
                query = query.Include(s => s.StudentsDisciplines)
                        .ThenInclude(sd => sd.Discipline)
                        .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking()
                         .OrderBy(s => s.Id)
                         .Where(student => student.StudentsDisciplines.Any(sd => sd.DisciplineId == disciplineId));

            return query.ToArray();
        }

        public Student GetStudentById(int id, bool includeTeacher)
        {
            IQueryable<Student> query = _context.Students;

            if (includeTeacher)
            {
                query.Include(s => s.StudentsDisciplines)
                     .ThenInclude(sd => sd.Discipline)
                     .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking().OrderBy(s => s.Id).Where(student => student.Id == id);
            return query.FirstOrDefault();
        }

        public Teacher[] GetAllTeachers(bool includeStudent)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeStudent)
            {
                query = query.Include(d => d.Disciplines)
                             .ThenInclude(sd => sd.StudentsDisciplines)
                             .ThenInclude(s => s.Student);
            }

            query = query.AsNoTracking().OrderBy(t => t.Id);
            return query.ToArray();
        }

        public Teacher[] GetAllTeachersByDisciplineId(int disciplineId, bool includeStudent)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeStudent)
            {
                query = query.Include(d => d.Disciplines)
                             .ThenInclude(sd => sd.StudentsDisciplines)
                             .ThenInclude(s => s.Student);
            }

            query = query.AsNoTracking()
                         .OrderBy(s => s.Id)
                         .Where(student => student.Disciplines.Any(
                             d => d.StudentsDisciplines.Any(sd => sd.DisciplineId == disciplineId)
                         ));

            return query.ToArray();
        }

        public Teacher GetTeacherById(int id, bool includeStudent)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeStudent)
            {
                query = query.Include(d => d.Disciplines)
                             .ThenInclude(sd => sd.StudentsDisciplines)
                             .ThenInclude(s => s.Student);
            }

            query = query.AsNoTracking()
                         .OrderBy(t => t.Id)
                         .Where(teacher => teacher.Id == id);

            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
