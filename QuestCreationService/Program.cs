using QuestCreationService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<QuestService>();
var app = builder.Build();

// Create a new quest
app.MapPost(
    "/quests",
    (QuestService service) =>
    {
        var quest = service.CreateQuest();
        return Results.Created($"/quests/{quest.Id}", quest);
    }
);

app.Run();
