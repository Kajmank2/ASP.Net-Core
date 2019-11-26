using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Komis.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Komis.Controllers                                                                  
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodrepository;
        public HomeController(ISamochodRepository samochodRepository)
        {
            this._samochodrepository = samochodRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var samochody = _samochodrepository.PobierzWszystkieSamochody().OrderBy(x => x.Marka);
            var homeVm = new HomeVM()
            {
                Tytul = "Przeglad Samochodow",
                Samochody = samochody.ToList()
        };
            return View(homeVm);
        }
        public IActionResult Szczegoly(int id)
        {
            var samochod = _samochodrepository.PobierzSamochodPoId(id);
            if (samochod == null)
                return NotFound();
            return View(samochod);
        }
    }
}
