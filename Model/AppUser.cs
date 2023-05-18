using Microsoft.AspNetCore.Identity;

namespace LibraryIdenity.Model
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
