using Microsoft.AspNetCore.Mvc;
using Univercity.Application.Interfaces;

namespace Univercity.UI.Controllers;

public class CoursesController: Controller
{
    private readonly ICourseService _courseService;

    public CoursesController (ICourseService courseService)
    {
        _courseService = courseService;
    }

    public ViewResult AllCourses()
    {
        return View(_courseService.ShowCourses());
    }
}
