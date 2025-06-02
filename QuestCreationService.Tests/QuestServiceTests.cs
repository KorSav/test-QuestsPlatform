namespace QuestCreationService.Tests;

public class QuestServiceTests
{
    [Fact]
    public void CreateQuest_ShouldReturnQuestWithIdAndTasks()
    {
        var service = new QuestService();
        var quest = service.CreateQuest();

        Assert.NotNull(quest);
        Assert.NotEqual(Guid.Empty, quest.Id);
        Assert.NotEmpty(quest.Tasks);
    }
}
