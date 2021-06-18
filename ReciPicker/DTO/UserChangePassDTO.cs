using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class UserChangePassDTO
    {
        public string Login{get;set;}
        public string Email { get; set; }
        public string Password { get; set; }
        public UserChangePassDTO(string Login, string Email, string Password)
        {
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;
        }
        public UserChangePassDTO() { }
    }
}

