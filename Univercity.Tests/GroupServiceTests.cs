using Univercity.Application;
using Univercity.Tests.Mocks;

namespace Univercity.Tests;

public class GroupServiceTests
{
    [Test]
    public void ShowGroups_ReturnsGroupCount()
    {
        MockGroupRepository mockGroupRepository = new MockGroupRepository();
        GroupService groupService = new GroupService(mockGroupRepository);

        int expected = 1;
        int actual = groupService.ShowGroups(1).Count();

        Assert.AreEqual(expected, actual);
    }
}
