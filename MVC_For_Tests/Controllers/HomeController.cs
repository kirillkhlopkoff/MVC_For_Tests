using Microsoft.AspNetCore.Mvc;
using MVC_For_Tests.Models;
using MVC_For_Tests.Services;
using System.Diagnostics;

namespace MVC_For_Tests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageService _messageService;

        public HomeController(ILogger<HomeController> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var message = _messageService.GetMessage();
            ViewData["Message"] = message;
            return View();
            //return View("Index", model: message);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}