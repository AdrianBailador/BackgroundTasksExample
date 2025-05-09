using BackgroundTasksDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Register queue and hosted service
builder.Services.AddSingleton<IBackgroundTaskQueue, BackgroundTaskQueue>();
builder.Services.AddHostedService<QueuedHostedService>();

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
