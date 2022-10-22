using Univercity.Data.Models;

namespace Univercity.Data.Interfaces;

public interface ICourseRepository
{
    IEnumerable<Course> Courses { get; }
}

