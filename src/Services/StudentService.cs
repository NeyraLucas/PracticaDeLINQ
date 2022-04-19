using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return student;
        }

        public Student GetById(int id)
        {
            return _dbContext.Students.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            var uiCourse = _dbContext.Students.FirstOrDefault(x => x.Id == courseId);
            return _dbContext.Students.Where(x => x.Id == uiCourse.Id);
        }

        public void DeleteById(int id)
        {
            _dbContext.Remove(id);
        }
    }
}