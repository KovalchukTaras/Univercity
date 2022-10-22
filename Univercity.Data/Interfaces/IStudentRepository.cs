using Univercity.Data.Models;

namespace Univercity.Data.Interfaces;

public interface IStudentRepository
{
    public IEnumerable<Student> GetStudents { get; }
    public void ChangeName(int id, string firstName, string lastName);
    public void DeleteStudent(int id);
    public void AddNewStudent(int groupId, string firstName, string lastName);
    public int GetGroupId(int studentId);
}