using Microsoft.AspNetCore.Mvc;
using Univercity.Application.Interfaces;

namespace Univercity.UI.Controllers;

public class StudentsController : Controller
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public ViewResult Students(int id)
    {
        return View(_studentService.ShowStudents(id));
    }

    public ActionResult DeleteStudent(int id)
    {
        int groupId = _studentService.DeleteStudentReturnGroupId(id);

        return RedirectToAction("Students", new {Id = groupId});
    }


    public ActionResult ChangeName(int id, string firstName, string lastName)
    {
        int groupId = _studentService.ChangeStudentNameReturnGroupId(id, firstName, lastName);

        return RedirectToAction("Students", new { id = groupId });
    }
}

