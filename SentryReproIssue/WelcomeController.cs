using Microsoft.AspNetCore.Mvc;

namespace SentryReproIssue;

public class WelcomeController : ControllerBase
{
    [HttpGet("")]
    public string Get()
    {
        return "Hello World!";
    }
}