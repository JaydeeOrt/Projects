using Microsoft.AspNetCore.Identity;

namespace GrumpyCoastGames.Models
{
    public class AppUser:IdentityUser
    {
        //Username
        public string DisplayName {  get; set; }
        //If you want emails or not;
        public bool NewsLetterOpt { get; set; }
    }
}
