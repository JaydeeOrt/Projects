using GrumpyCoastGames.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrumpyCoastGames.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<AppUser>(options)
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
    }
}
