using kipasCalisanlar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace kipasCalisanlar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly calisanlarContext _context;

        public HomeController(ILogger<HomeController> logger, calisanlarContext context)
        {
            _logger = logger;
            _context = context; 
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.calisanListe=_context.Elemanlars.ToList(); 
            return View();
        }
        [HttpPost]
        public IActionResult Index(Elemanlar eleman)
        {
            _context.Add(eleman);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Kisi_Guncelle(int id) {
            var guncellenecekKisi = _context.Elemanlars.Find(id);
            return View(guncellenecekKisi);
        }
        [HttpPost]
        public IActionResult Kisi_Guncelle(Elemanlar eleman)
        {
            _context.Update(eleman);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
           
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
