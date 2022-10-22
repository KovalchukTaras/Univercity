using Univercity.Data.Interfaces;
using Univercity.Data.Models;

namespace Univercity.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContent _appDbContent;

        public CourseRepository(AppDbContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Course> Courses => _appDbContent.Courses;
    }
}

