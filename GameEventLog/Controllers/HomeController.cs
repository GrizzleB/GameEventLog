using GameEventLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameEventLog.Controllers
{
    public class HomeController : Controller
    {
        private EventContext context { get; set; }
        public HomeController(EventContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var events = context.Events;
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Event evt)
        {
            if (ModelState.IsValid)
            {
                context.Events.Add(evt);
                context.SaveChanges();
            }
            else
            {
                return View("Add", evt);
            }
            return RedirectToAction("Index", "Home");
        }

        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}