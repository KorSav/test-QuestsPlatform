using QuestViewingService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ViewingService>();
var app = builder.Build();

// List all quests
app.MapGet(
    "/quests",
    (ViewingService service) =>
    {
        return Results.Ok(service.GetAll());
    }
);

// View a specific quest
app.MapGet(
    "/quests/{id:guid}",
    (Guid id, ViewingService service) =>
    {
        var quest = service.GetById(id);
        return quest is not null ? Results.Ok(quest) : Results.NotFound();
    }
);

// Search quests by title (just an example of a more complex query)
app.MapGet(
    "/quests/search",
    (string query, ViewingService service) =>
    {
        var results = service.Search(query);
        return Results.Ok(results);
    }
);

app.Run();
