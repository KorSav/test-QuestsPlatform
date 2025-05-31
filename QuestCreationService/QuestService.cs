using Bogus;

namespace QuestCreationService;

public class QuestService
{
    private readonly Faker _faker = new();

    public Quest CreateQuest()
    {
        return new Quest
        {
            Id = Guid.NewGuid(),
            Title = _faker.Lorem.Sentence(),
            Tasks = _faker.Make(3, () => _faker.Lorem.Sentence()).ToList(),
        };
    }
}
