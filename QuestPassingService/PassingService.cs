namespace QuestPassingService;

public class PassingService
{
    private readonly Dictionary<Guid, QuestProgress> _store = [];

    public QuestProgress StartQuest(Guid questId)
    {
        var progress = new QuestProgress
        {
            QuestId = questId,
            TotalTasks = 5,
            CompletedTasks = 0,
        };

        _store[questId] = progress;
        return progress;
    }

    public QuestProgress? AnswerTask(Guid questId)
    {
        if (_store.TryGetValue(questId, out var progress))
        {
            progress.CompletedTasks = Math.Min(progress.CompletedTasks + 1, progress.TotalTasks);
            return progress;
        }
        return null;
    }
}
