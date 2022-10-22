using Microsoft.AspNetCore.Mvc;
using Univercity.Application.Interfaces;


namespace Univercity.UI.Controllers;

public class GroupsController : Controller
{
    private readonly IGroupService _groupService;

    public GroupsController (IGroupService groupService)
    {
        _groupService = groupService;
    }

    public ViewResult Groups(int Id)
    {
        return View(_groupService.ShowGroups(Id));
    }

    public ActionResult DeleteGroup(int Id)
    {
        int courseId = _groupService.DeleteGroupReturnCourseId(Id); ;
        
        return RedirectToAction("Groups", new { Id = courseId });
    }

    public ActionResult ChangeName(int Id, string name)
    {
        int courseId = _groupService.ChangeGroupNameReturnCourseId(Id, name);

        return RedirectToAction("Groups", new { Id = courseId });
    }

}

