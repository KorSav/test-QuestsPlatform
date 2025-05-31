namespace QuestPassingService;

public class QuestProgress
{
    public Guid QuestId { get; set; }
    public int TotalTasks { get; set; }
    public int CompletedTasks { get; set; }
}
