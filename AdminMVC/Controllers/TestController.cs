using Microsoft.AspNetCore.Mvc;

namespace AdminMVC.Controllers;

public class TestController : Controller
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(string logString)
    {
        _logger.LogInformation("Ввод от пользователя: {LogString}", logString);
        ViewBag.logString = logString;
        return View();
    }
}