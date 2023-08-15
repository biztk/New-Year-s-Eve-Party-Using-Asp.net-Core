using Microsoft.AspNetCore.Mvc;
using New_Year_s_Eve_Party_Using_Asp.net_Core.Models;
using System.Diagnostics;

namespace New_Year_s_Eve_Party_Using_Asp.net_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult GoPartyGustForm()
        {

            return View();
        }

        [HttpPost]
        public ViewResult GoPartyGustForm(PartyGuestResponse partyGuestResponse)
        {
            Repository.AddResponse(partyGuestResponse);
            return View("Thanks", partyGuestResponse);

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