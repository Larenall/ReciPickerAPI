using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class InUserSignInDTO
    {
        public string LoginOrEmail {get;set;}
        public string Password { get; set; }
        public InUserSignInDTO(string LoginOrEmail,string Password)
        {
            this.LoginOrEmail = LoginOrEmail;
            this.Password = Password;
        }
        public InUserSignInDTO() { }
    }
}

