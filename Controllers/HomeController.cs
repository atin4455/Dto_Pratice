using Dto_Pratice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dto_Pratice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult DtoDemo()
        {
            var dto = new UserDto
            {
                Id = 1,
                Name = "示範使用者",
                Email = "demo@example.com"
            };

            var vm = new UserDemoViewModel
            {
                User = dto,
                Greeting = $"嗨，{dto.Name}（這行只為畫面組字，不屬於 DTO）"
            };
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
