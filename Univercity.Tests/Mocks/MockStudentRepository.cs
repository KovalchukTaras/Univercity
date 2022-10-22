using Univercity.Data.Interfaces;
using Univercity.Data.Models;

namespace Univercity.Tests.Mocks
{
    public class MockStudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetStudents
        {
            get
            {
                List<Student> studentList = new List<Student>
                {
                    new Student { Id = 1, GroupId = 1, FirstName = "Samah", LastName = "Valdez" },
                    new Student { Id = 2, GroupId = 1, FirstName = "Korban", LastName = "Forster" },
                    new Student { Id = 3, GroupId = 1, FirstName = "Hania", LastName = "Chester" },
                    new Student { Id = 4, GroupId = 22, FirstName = "Maxime", LastName = "Bone" },
                    new Student { Id = 5, GroupId = 1, FirstName = "Dev", LastName = "Justice" },
                    new Student { Id = 6, GroupId = 1, FirstName = "Anderson", LastName = "Carver" },
                    new Student { Id = 7, GroupId = 1, FirstName = "Daisy", LastName = "Hickman" },
                    new Student { Id = 8, GroupId = 2, FirstName = "Annabella", LastName = "Garrison" },
                    new Student { Id = 9, GroupId = 3, FirstName = "Preston", LastName = "Burks" },
                    new Student { Id = 10, GroupId = 2, FirstName = "Shanna", LastName = "Erickson" },
                    new Student { Id = 11, GroupId = 2, FirstName = "Ian", LastName = "Wolfe" },
                    new Student { Id = 12, GroupId = 2, FirstName = "Norah", LastName = "Franks" },
                    new Student { Id = 13, GroupId = 5, FirstName = "Danniella", LastName = "Gould" },
                    new Student { Id = 14, GroupId = 2, FirstName = "Chelsey", LastName = "Rennie" },
                    new Student { Id = 15, GroupId = 2, FirstName = "Mica", LastName = "Schaefer" },
                    new Student { Id = 16, GroupId = 3, FirstName = "Tyler", LastName = "Nicholls" },
                    new Student { Id = 17, GroupId = 21, FirstName = "Ayra", LastName = "Moyer" },
                    new Student { Id = 18, GroupId = 3, FirstName = "Gabriela", LastName = "Stevens" },
                    new Student { Id = 19, GroupId = 3, FirstName = "Olivia-Rose", LastName = "Sears" }
                };
                IEnumerable<Student> students = studentList;
                return students;
            }
        }

        public void AddNewStudent(int groupId, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(int id, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public int GetGroupId(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}

