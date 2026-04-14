using Dto_Pratice.Models;
using Dto_Pratice.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dto_Pratice.Controllers
{
    public class HomeController(IUserDemoService userDemoService) : Controller
    {
        public IActionResult DtoDemo()
        {
            return View(userDemoService.GetDtoDemoPage());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
