using Univercity.Data.Interfaces;
using Univercity.Data.Models;

namespace Univercity.Data.Repository;

public class GroupRepository: IGroupRepository
{
    private readonly AppDbContent _appDbContent;

    public GroupRepository(AppDbContent appDbContent)
    {
        _appDbContent = appDbContent;
    }

    public IEnumerable<Group> ShowGroups => _appDbContent.Groups;

    public void DeleteGroup(int groupId)
    {
        var groupToDel = _appDbContent.Groups.SingleOrDefault(x => x.Id == groupId);
        int studentCount = GetStudentCount(groupId);

        if (groupToDel != null && studentCount == 0)
        {
            _appDbContent.Groups.Remove(groupToDel);
            _appDbContent.SaveChanges();
        }
    }

    public void ChangeName(int groupId, string name)
    {
        var group = _appDbContent.Groups.SingleOrDefault(s => s.Id == groupId);
        if (group != null)
        {
            if (name != null)
            {
                group.GroupName = name;
                _appDbContent.SaveChanges();
            }
        }
    }


    public int GetCourseId(int groupId)
    {
        var group = _appDbContent.Groups.SingleOrDefault(s => s.Id == groupId);
        return group.CourseId;
    }



    private int GetStudentCount(int groupId)
    {
        int count = _appDbContent.Students.Where(s => s.GroupId == groupId).Count();
        return count;
    }
}

