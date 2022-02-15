using Microsoft.AspNetCore.Mvc;

namespace bindings.Controllers;

[ApiController]
[Route("[controller]")]
public class ProcessController : ControllerBase
{
    private readonly ILogger<ProcessController> _logger;

    public ProcessController(ILogger<ProcessController> logger)
    {
        _logger = logger;
    }

    [HttpPost("/tweets")]
    public void Run([FromBody] object body)
    {
        _logger.LogInformation(body.ToString());
    }
}
