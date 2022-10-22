using Univercity.Data.Models;

namespace Univercity.Application.Interfaces;

public interface IGroupService
{
    public IEnumerable<Group> ShowGroups(int courseId);
    public int DeleteGroupReturnCourseId(int groupId);
    public int ChangeGroupNameReturnCourseId(int groupId, string name);
}

