using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S1.Models
{
    public class KobietaController : Controller
    {

        public ActionResult Index()
        {
            Auta nr1 = new Auta();
            nr1.Marka = "Bentley";
            nr1.Model = "Continental";
            nr1.Nadwozie = "Coupe Sport";
            nr1.Paliwo = "benzyna";
            nr1.Pojemnosc_Silnika = 5998;
            nr1.Rok_Produkcji = 2005;
            nr1.Cena = 479000;

            Auta nr2 = new Auta();
            nr2.Cena = 20000;
            nr2.Marka = "Bentley";
            nr2.Model = "Turbo R";
            nr2.Nadwozie = "sedan";
            nr2.Paliwo = "benzyna";
            nr2.Pojemnosc_Silnika = 6753;
            nr2.Rok_Produkcji = 1985;

            Auta nr3 = new Auta();
            nr3.Cena = 477009;
            nr3.Marka = "Aston Martin";
            nr3.Model = "V12 Vanquish";
            nr3.Nadwozie = "coupe";
            nr3.Paliwo = "diesel";
            nr3.Pojemnosc_Silnika = 6000;
            nr3.Rok_Produkcji = 2013;

            List<Auta> lista = new List<Auta> { nr1, nr2, nr3 };

            ViewBag.AutoNr1 = JsonHelper.JsonSerializer<Auta>(nr1);//można by z tego utworzyć deserializowaną listę.
            ViewBag.AutoNr2 = JsonHelper.JsonSerializer<Auta>(nr2);
            ViewBag.AutoNr3 = JsonHelper.JsonSerializer<Auta>(nr3);


            ViewBag.Serializacja = JsonHelper.JsonSerializer<List<Auta>>(lista);
            List<Auta> Deserializacja = JsonHelper.JsonDeserialize<List<Auta>>(ViewBag.Serializacja);


            return View("Index", Deserializacja);
        }
    }
}
