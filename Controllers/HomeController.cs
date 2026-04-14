using Dto_Pratice.Models;
using Dto_Pratice.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dto_Pratice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDemoService _userDemoService;

        // 建構子名稱必須與類別名稱 HomeController 一致
        public HomeController(IUserDemoService userDemoService)
        {
            _userDemoService = userDemoService;
        }

        public IActionResult DtoDemo()
        {
            // 使用注入的 Service 取得資料
            var model = _userDemoService.GetDtoDemoPage();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}