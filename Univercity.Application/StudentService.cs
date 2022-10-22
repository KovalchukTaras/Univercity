using Univercity.Application.Interfaces;
using Univercity.Data.Models;
using Univercity.Data.Interfaces;

namespace Univercity.Application;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public IEnumerable<Student> ShowStudents(int groupId)
    {
        IEnumerable<Student> students = _studentRepository.GetStudents;
        if (groupId != 0)
        {
            students = _studentRepository.GetStudents.Where(s => s.GroupId == groupId);
        }
        return students;
    }

    public int ChangeStudentNameReturnGroupId(int studentId, string firstName, string lastName)
    {
        _studentRepository.ChangeName(studentId, firstName, lastName);
        return _studentRepository.GetGroupId(studentId);
    }

    public int DeleteStudentReturnGroupId(int studentId)
    {
        int groupId = _studentRepository.GetGroupId(studentId);
        _studentRepository.DeleteStudent(studentId);
        return groupId;
    }
}

