using esercizio_25_06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic; // Assicurati di includere questo using per List<>

namespace esercizio_25_06.Controllers
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

            var Cv = new Cv();
             
            {
                Cv.InformazioniPersonali.Nome = "Rosario";
                Cv.InformazioniPersonali.Cognome = "Santoro";
                Cv.InformazioniPersonali.Indirizzo = "Via Roma 1";
                Cv.InformazioniPersonali.Telefono = "3333333333";
                Cv.InformazioniPersonali.Email = "assaas@libero.it";

            };

            Cv.Studi = new Studi 
            {
                qualifica = "Diploma",
                istituto = "ITIS",
                tipo = "Scientifico",
                dataInizio = new DateTime(2010, 9, 1),
                dataFine = new DateTime(2015, 6, 30)
            };

            Cv.Impieghi = new Impieghi 
            {
                Esperienza = new List<Esperienza>()
            };

            var esperienza = new Esperienza
            {
                azienda = "Microsoft",
                jobTitle = "Sviluppatore",
                dataInizio = new DateTime(2015, 9, 1),
                dataFine = new DateTime(2024, 6, 30),
                descrizione = "Sviluppo di applicazioni web classe nello rizzo",
                compiti = "Sviluppo di applicazioni web con ASP.NET MVC"
            };
            Cv.Impieghi.Esperienza.Add(esperienza);

            return View(Cv);
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
