using Univercity.Application.Interfaces;
using Univercity.Data.Models;
using Univercity.Data.Interfaces;

namespace Univercity.Application;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public  CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public IEnumerable<Course> ShowCourses()
    {
        return _courseRepository.Courses;
    }
}

