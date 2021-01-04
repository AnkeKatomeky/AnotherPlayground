using Microsoft.AspNetCore.Mvc;
using System;

namespace EmptyWeb.Controllers
{
    public class MainPageController : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Self()
        {
            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString();
            return Content($"Hello on Main{Environment.NewLine} controller: {controller} | action: {action}");
        }

        [Route("Reactor/{react}")]
        public IActionResult Reactor(string react)
        {
            return Content($"React on {react} message");
        }

        [Route("")]
        public IActionResult MainPage()
        {
            return View();
        }


        [Route("default")]
        public IActionResult Default()
        {
            return View();
        }
    }
}