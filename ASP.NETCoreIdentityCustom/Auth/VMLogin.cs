

using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreIdentityCustom.Auth
{
    public class VMLogin
    {

        [Required(ErrorMessage = "User Name is required")]
        public string ?Email { get; set; }
        public string ?PassWord { get; set; }
        public bool KeepLoggedIn { get; set; }

        public bool LogOut { get; set; }
        public string ?Password { get; set; }
       
            
    }
}

