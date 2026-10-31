using ITHelpDesk1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITHelpDeskTeam1.Controllers
{
    public class TicketController : Controller
    {
        private static List<Ticket> _tickets = new List<Ticket>();

        public IActionResult Index()
        {
            return View(_tickets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            _tickets.Add(ticket);
            return RedirectToAction("Index");
        }
    }
}