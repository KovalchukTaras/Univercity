using Univercity.Data.Interfaces;
using Univercity.Data.Models;

namespace Univercity.Data.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AppDbContent _appDbContent;

        public StudentRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Student> GetStudents => _appDbContent.Students;

        public void ChangeName(int id, string firstName, string lastName)
        {
            var student = _appDbContent.Students.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                if (firstName != null)
                {
                    student.FirstName = firstName;
                }
                if (lastName != null)
                {
                    student.LastName = lastName;
                }
                _appDbContent.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _appDbContent.Students.SingleOrDefault(s => s.Id == id);
            if (student != null)
            {
                _appDbContent.Students.Remove(student);
                _appDbContent.SaveChanges();
            }
        }

        public void AddNewStudent(int groupId, string firstName, string lastName)
        {
            Student newStudent = new Student();
            newStudent.GroupId = groupId;
            newStudent.FirstName = firstName;
            newStudent.LastName = lastName;

            _appDbContent.Students.Add(newStudent);
            _appDbContent.SaveChanges();
        }

        public int GetGroupId(int studentId)
        {
            var student = _appDbContent.Students.SingleOrDefault(s => s.Id == studentId);
            return student.GroupId;
        }

    }
}

