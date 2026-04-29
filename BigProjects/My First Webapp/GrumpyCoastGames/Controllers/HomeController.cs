using GrumpyCoastGames.Data;
using GrumpyCoastGames.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Diagnostics;

namespace GrumpyCoastGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext context) 
        { _db = context; }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Games()
        {
            var games = await _db.Games.ToListAsync();
            return View(games);
        }
        public async Task<IActionResult> Developers()
        {
            var dev = await _db.Developers.ToListAsync();
            return View(dev);
        }
        public IActionResult Media()
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
