using QuestPassingService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<PassingService>();
var app = builder.Build();

// Start a new quest progress
app.MapPost(
    "/progress/{id:guid}",
    (Guid id, PassingService service) =>
    {
        var progress = service.StartQuest(id);
        return Results.Created($"/progress/{id}", progress);
    }
);

// Answer a task in a quest
app.MapPut(
    "/progress/{id:guid}/answer",
    (Guid id, PassingService service) =>
    {
        var result = service.AnswerTask(id);
        return result is not null ? Results.Ok(result) : Results.NotFound();
    }
);

app.Run();
