using EmptyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EmptyWeb.Controllers
{
    public class MainPageController : Controller
    {
        private UsersContext _context;

        public MainPageController(UsersContext context)
        {
            _context = context;
        }

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
            return View(_context.Users.ToList());
        }

        [Route("default")]
        public IActionResult Default()
        {
            return View();
        }
    }
}