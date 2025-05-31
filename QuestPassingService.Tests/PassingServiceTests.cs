namespace QuestPassingService.Tests;

public class PassingServiceTests
{
    [Fact]
    public void StartQuest_ShouldInitializeProgress()
    {
        var service = new PassingService();
        var id = Guid.NewGuid();

        var progress = service.StartQuest(id);

        Assert.Equal(id, progress.QuestId);
        Assert.Equal(0, progress.CompletedTasks);
        Assert.True(progress.TotalTasks > 0);
    }

    [Fact]
    public void AnswerTask_ShouldIncrementProgress()
    {
        var service = new PassingService();
        var id = Guid.NewGuid();
        service.StartQuest(id);

        var progress = service.AnswerTask(id);

        Assert.NotNull(progress);
        Assert.Equal(1, progress!.CompletedTasks);
    }
}
