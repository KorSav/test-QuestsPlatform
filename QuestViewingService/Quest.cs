namespace QuestViewingService;

public class Quest
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public double Rating { get; set; }
}
