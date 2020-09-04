using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;

namespace timeDisplay.HomeController
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.date = DateTime.Now.ToString("MMM d, yyyy");
            ViewBag.time = DateTime.Now.ToString("hh:mm tt");
            return View();
        }
    }
}