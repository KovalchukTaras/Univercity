using Univercity.Application;
using Univercity.Tests.Mocks;

namespace Univercity.Tests;

public class StudentServiceTests
{
    [Test]
    public void ShowStudents_ReturnsStudentList()
    {
        MockStudentRepository mockStudentRepository = new MockStudentRepository();
        StudentService studentService = new StudentService(mockStudentRepository);

        int expected = 6;
        int actual = studentService.ShowStudents(1).Count();

        Assert.AreEqual(expected, actual);
    }
}

