using GrumpyCoastGames.Models;
using Microsoft.AspNetCore.Identity;
using static System.Net.Mime.MediaTypeNames;
namespace GrumpyCoastGames.Data
{
    public class SeedData
    {
        public static async Task SeedRolesAsync(IServiceProvider service)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

            String[] roles = { "User", "Admin" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }//End If
            }//end For loop
        }


        public static async Task SeedGamesAsync(IServiceProvider service)
        {
            var games = service.GetRequiredService<ApplicationDbContext>();
            if (!games.Games.Any())
            {//adds games to database
                games.Games.AddRange(
                new Game
                {
                    Name = "Glorpys Revenge",
                    Description = "After planet Glorpon was attacked by humans they took it upon themselves to create a weapon to stop humans from taking their planet!\n" +
                    "The Ultima Weapon and in the end they made an abomination Glorpy the worm.What they didnt know was that this was a weapon outside their " +
                    "mortal control! It quickly became to powerfull and devoured its home world whole, it continues to devour everything in its way......",
                    Stage = "Releasing 04/30/2026",
                    Image = ""
                },
                new Game
                {
                    Name = "Glorpy Survivors",
                    Description = "After crash landing on planet G10RP, the survivin astronauts had to survive and buy time for their " +
                    "ships repairs to be completed before they could leave this infested planet! They remained unaware of the hate that grew within these alien creatures.\n" +
                    "The longer they stayed on the planet the more intese the aliens fought until the human left. Will this be the last we see of the Glorpy aliens?",
                    Stage = "Releasing December 2026",
                    Image = ""
                },
                new Game
                {
                    Name = "Grumpy Mage",
                    Description = "Have you ever thought to your self no wizard game gives you the feeling of an all powerful mage? Well we here at Grumpy Coast Games have" +
                    " and we have taken it upon ourselves to make the greatest mage game ever created! We have taken ideas from all the decent mage games out currently from " +
                    "Noita, Spell Masons, and even from Wizards of legend! Prepare yourself for the release of the worlds BEST mage game ever created by a small group of developers!\n" +
                    "'We Love Casting Spells!'",
                    Stage = "In Development",
                    Image = ""
                },
                new Game
                {
                    Name = "Phasmo-Kaisen",
                    Description = "Have you every played Phasmophobia but thought to yourself,\n" +
                    "Darn I wish this game was fun and I wish to fight ghost!\n" +
                    "Dont look further than Phasmo-Kaisen in this ghost hunting game! Not only do your need to track them," +
                    "figure out thier type, You also MUST exorcise them using your occult magic!\n" +
                    "Try this new game out and hit your first black flash and go plus ultra!",
                    Stage = "In Super Early Development",
                    Image = ""
                });

                await games.SaveChangesAsync();

            }
        }


        public static async Task SeedDevelopersAsync(IServiceProvider service)
        {
            var devs = service.GetRequiredService<ApplicationDbContext>();
            if (!devs.Developers.Any())
            {//adds Developers to database
                devs.Developers.AddRange(
                new Developer
                {
                    Name = "Grumpy Jesus",
                    Position = "Lead Develooper",
                    Description = "Obstacles must be dealt with head on!\nIts important to know whats wrong and dealing with it!" +
                    "\nI am the lead for Grumpy Mage game, it is a passion of mine i'm making what I always wanted",
                    Image = ""
                },
                new Developer
                {
                    Name = "Grumpy Artif",
                    Position = "Lead Animator",
                    Description = "I have been animating for about 6 Years!" +
                    "\nLove working here great peopld!",
                    Image = ""
                },
                new Developer
                {
                    Name = "Grumpy Jacob",
                    Position = "Programer",
                    Description = "This is a Great company I would lay my life down for! They paid for my Schooling and even gave me time off when I needed it." +
                    "\nI am the lead developer for Phasmo-Kaisen, the best thing about this company is that you are able to work on projects you are passionate about",
                    Image = ""
                },
                new Developer
                {
                    Name = "Grumpy Steve",
                    Position = "Programer, Animator",
                    Description = "Ive been working for this company since its fouding, I usually just help around wherever I am needed!" +
                    "\nGreat working envorionment and great coworkers! I would recommend everyone to try and work for a company like this.",
                    Image = ""
                },
                new Developer
                {
                    Name = "Grumpy Jules",
                    Position = "Junior Programer",
                    Description = "Im glad I got hired very fun I am mostly helping on working on Phasmo-Kaisen",
                    Image = ""
                });
            }//End IF
        }

    }
}
