using Microsoft.AspNetCore.Identity;

namespace maihelper.Models.Identity
{
    public class User : IdentityUser
    {
        public string Login { get; set; }
    }
}
