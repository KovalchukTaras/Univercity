using Univercity.Data.Interfaces;
using Univercity.Data.Models;

namespace Univercity.Tests.Mocks
{
    public class MockGroupRepository : IGroupRepository
    {
        public void ChangeName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteGroup(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCourseId(int groupId)
        {
            return 1;
        }

        public IEnumerable<Group> ShowGroups
        {
            get
            {
                List<Group> groupList = new List<Group>
                {
                    new Group { Id = 1, CourseId = 1, GroupName = "SR-01" },
                    new Group { Id = 2, CourseId = 2, GroupName = "SR-02" },
                    new Group { Id = 3, CourseId = 3, GroupName = "SR-03" }
                };
                IEnumerable<Group> groups = groupList;
                return groups;
            }
        }
    }
}

