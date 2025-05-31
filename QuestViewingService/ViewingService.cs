using Bogus;

namespace QuestViewingService;

public class ViewingService
{
    private readonly List<Quest> _quests;

    public ViewingService()
    {
        var faker = new Faker();
        _quests = [];
        for (int i = 0; i < 5; i++)
        {
            _quests.Add(
                new Quest
                {
                    Id = Guid.NewGuid(),
                    Title = faker.Lorem.Sentence(),
                    Rating = Math.Round(faker.Random.Double(0, 5), 1),
                }
            );
        }
        _quests.Add(
            new Quest
            {
                Id = Guid.Parse("dac6dd41-54a4-481a-8407-432b6c0a63ef"),
                Title = faker.Lorem.Sentence(),
                Rating = Math.Round(faker.Random.Double(0, 5), 1),
            }
        );
    }

    public IEnumerable<Quest> GetAll() => _quests;

    public Quest? GetById(Guid id) => _quests.FirstOrDefault(q => q.Id == id);

    public IEnumerable<Quest> Search(string query) =>
        _quests.Where(q => q.Title.Contains(query, StringComparison.OrdinalIgnoreCase));
}
