using GrumpyCoastGames.Data;
using GrumpyCoastGames.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
namespace GrumpyCoastGames.Controllers
{
    //Admin Only Page
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _db;
        public AdminController(UserManager<AppUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            //Getting users from data
            var users = _userManager.Users.ToList();

            //Dictionary of userID's and Roles
            var userRoles = new Dictionary<string, IList<string>>();
            foreach (var user in users)
            {
                userRoles[user.Id] = await _userManager.GetRolesAsync(user);
            }
            //Pass Dictionary to viewbag
            ViewBag.UserRoles = userRoles;
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> Promote(string userID)
        {
            //User ID
            var user = await _userManager.FindByIdAsync(userID);

            if (user != null)
            {
                //Removes Role User
                await _userManager.RemoveFromRoleAsync(user, "User");

                //Adds Admin
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            //Back To Index
            return RedirectToAction("Index");
        }


        //Get Data
        public async Task<IActionResult> Games()
        {
            var games = await _db.Games.ToListAsync();
            return View(games);
        }

        //Create Game
        public IActionResult CreateGame()
        {
            return View();
        }

        [HttpPost]//Uses IFormFile to add image file
        public async Task<IActionResult> CreateGame(Game game, IFormFile imageFile)//IFormFile for images
        {
            //Check file isnt null and valid
            if (imageFile != null && imageFile.Length >0)
            {
                var fileName = Path.GetFileName(imageFile.FileName);
                var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", fileName);

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                game.Image = "/Images/" + fileName;
            }


            if (ModelState.IsValid)
            {
                _db.Games.Add(game);
                await _db.SaveChangesAsync();
                return RedirectToAction("Games");
            }
            return View(game);
        }
        //Edit Games
        public async Task<IActionResult> EditGame(int id)
        {
            var game = await _db.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost]
        public async Task<IActionResult> EditGame(Game game, IFormFile imageFile)
        {
            //Check file isnt null and valid
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileName(imageFile.FileName);
                var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", fileName);

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }


                game.Image = "/Images/" + fileName;
            }

            if (ModelState.IsValid)
            {
                _db.Games.Update(game);
                await _db.SaveChangesAsync();
                return RedirectToAction("Games");
            }
            return View(game);
        }

        //Delete
        [HttpPost]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var game = await _db.Games.FindAsync(id);

            if (game != null)
            {
                _db.Games.Remove(game);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Games");
        }

        //Employee CRUD
        public async Task<IActionResult> Developers()
        {
            var devs = await _db.Developers.ToListAsync();
            return View(devs);
        }

        //Create Game
        public IActionResult AddDeveloper()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDeveloper(Developer dev, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileName(imageFile.FileName);
                var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", fileName);

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }


                dev.Image = "/Images/" + fileName;
            }

            if (ModelState.IsValid)
            {
                _db.Developers.Add(dev);
                await _db.SaveChangesAsync();
                return RedirectToAction("Developers");
            }
            return View(dev);
        }
        //Edit Games
        public async Task<IActionResult> EditDeveloper(int id)
        {
            var dev = await _db.Developers.FindAsync(id);
            if (dev == null)
            {
                return NotFound();
            }
            return View(dev);
        }

        [HttpPost]
        public async Task<IActionResult> EditDeveloper(Developer dev, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = Path.GetFileName(imageFile.FileName);
                var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", fileName);

                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }


                dev.Image = "/Images/" + fileName;
            }

            if (ModelState.IsValid)
            {
                _db.Developers.Update(dev);
                await _db.SaveChangesAsync();
                return RedirectToAction("Developers");
            }
            return View(dev);
        }

        //Delete
        [HttpPost]
        public async Task<IActionResult> RemoveDeveloper(int id)
        {
            var dev = await _db.Developers.FindAsync(id);

            if (dev != null)
            {
                _db.Developers.Remove(dev);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Developers");
        }
    }
}
