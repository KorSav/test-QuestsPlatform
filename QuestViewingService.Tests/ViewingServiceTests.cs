namespace QuestViewingService.Tests;

public class ViewingServiceTests
{
    [Fact]
    public void GetAll_ShouldReturnInitialQuests()
    {
        var service = new ViewingService();
        var quests = service.GetAll();

        Assert.NotNull(quests);
        Assert.NotEmpty(quests);
    }

    [Fact]
    public void GetById_ShouldReturnQuest_IfExists()
    {
        var service = new ViewingService();
        var existing = service.GetAll().First();

        var result = service.GetById(existing.Id);

        Assert.NotNull(result);
        Assert.Equal(existing.Id, result.Id);
    }
}
