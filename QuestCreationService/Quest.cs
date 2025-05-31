namespace QuestCreationService;

public class Quest
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<string> Tasks { get; set; } = [];
}
