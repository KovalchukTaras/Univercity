using Univercity.Application.Interfaces;
using Univercity.Data.Models;
using Univercity.Data.Interfaces;

namespace Univercity.Application;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;

    public GroupService(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }


    public IEnumerable<Group> ShowGroups(int courseId)
    {
        IEnumerable<Group> groups = _groupRepository.ShowGroups;
        if (courseId != 0)
        {
            groups = _groupRepository.ShowGroups.Where(g => g.CourseId == courseId);
        }
        return groups;
    }

    public int ChangeGroupNameReturnCourseId(int groupId, string name)
    {
        int courseId = _groupRepository.GetCourseId(groupId);
        _groupRepository.ChangeName(groupId, name);

        return courseId;
    }

    public int DeleteGroupReturnCourseId(int groupId)
    {
        int courseId = _groupRepository.GetCourseId(groupId);
        _groupRepository.DeleteGroup(groupId);

        return courseId;
    }
}