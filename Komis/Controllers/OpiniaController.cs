using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Komis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    [Authorize]
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepozitory _opiniaRepozitory;
        public OpiniaController(IOpiniaRepozitory opiniaRepository)
        {
            _opiniaRepozitory = opiniaRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                _opiniaRepozitory.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}