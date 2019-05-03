using Komis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodResposytory _samochodReposytory;

        public HomeController(ISamochodResposytory samochodReposytory)
        {
            _samochodReposytory = samochodReposytory;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Tytul = "Przegląd Samochodów";
            var samochody = _samochodReposytory.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            return View(samochody);
        }
    }
}
