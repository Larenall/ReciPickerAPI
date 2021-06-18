using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class User
    {

        public int UserId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
        public User(string Login, string Email, string Password, string Salt, string Role = "user")
        {
            this.Login = Login;
            this.Email = Email;
            this.Password = Password;
            this.Salt = Salt;
            this.Role = Role;
        }

    }
}
