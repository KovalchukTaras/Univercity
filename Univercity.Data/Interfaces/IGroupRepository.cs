using Univercity.Data.Models;

namespace Univercity.Data.Interfaces;

public interface IGroupRepository
{
    public IEnumerable<Group> ShowGroups { get; }
    public void DeleteGroup(int id);
    public void ChangeName(int id, string name);
    public int GetCourseId(int groupId);
}

