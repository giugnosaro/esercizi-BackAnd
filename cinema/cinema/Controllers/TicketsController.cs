using cinema.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace cinema.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            var model = new TicketViewModel
            {
                Guests = DataStore.Guests,
                Cinemas = DataStore.Cinemas
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult BuyTicket(string firstName, string lastName, string sala, string ticketType)
        {
            var cinema = DataStore.Cinemas.FirstOrDefault(c => c.Name == sala);
            if (cinema != null && cinema.TotalTicketsSold >= cinema.Capacity)
            {
                ModelState.AddModelError("", "Sala piena!");
            }
            else
            {
                var guest = new Guest { FirstName = firstName, LastName = lastName, Sala = sala, TicketType = ticketType };
                DataStore.Guests.Add(guest);
                cinema.TotalTicketsSold++;
                if (ticketType == "Ridotto")
                {
                    cinema.ReducedTicketsSold++;
                }
            }

            var model = new TicketViewModel
            {
                Guests = DataStore.Guests,
                Cinemas = DataStore.Cinemas
            };
            return View("Index", model);
        }
    }
}
