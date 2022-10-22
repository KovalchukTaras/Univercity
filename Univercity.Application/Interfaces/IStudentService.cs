using Univercity.Data.Models;

namespace Univercity.Application.Interfaces;

public interface IStudentService
{
    public IEnumerable<Student> ShowStudents(int groupId);
    public int ChangeStudentNameReturnGroupId(int studentId, string firstName, string lastName);
    public int DeleteStudentReturnGroupId(int studentId);
}

