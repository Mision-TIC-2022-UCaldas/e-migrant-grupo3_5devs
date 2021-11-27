using Microsoft.AspNetCore.Identity;

namespace E_Migrant.App.Frontend.Areas.Identity.Data
{
    public class AplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; }

        [PersonalData]
        public string Rol { get; set; }
    }
}