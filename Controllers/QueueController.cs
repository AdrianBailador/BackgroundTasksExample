using BackgroundTasksDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundTasksDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QueueController : ControllerBase
{
    private readonly IBackgroundTaskQueue _queue;
    private readonly ILogger<QueueController> _logger;

    public QueueController(IBackgroundTaskQueue queue, ILogger<QueueController> logger)
    {
        _queue = queue;
        _logger = logger;
    }

    [HttpPost("enqueue")]
    public IActionResult Enqueue()
    {
        _queue.QueueBackgroundWorkItem(async token =>
        {
            _logger.LogInformation("Queued task started.");
            await Task.Delay(3000, token);
            _logger.LogInformation("Queued task completed.");
        });

        return Ok("Task glued.");
    }
}
