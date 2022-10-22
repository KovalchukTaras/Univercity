using Univercity.Data.Models;

namespace Univercity.Application.Interfaces
{
    public interface ICourseService
    {
        public IEnumerable<Course> ShowCourses();
    }
}

