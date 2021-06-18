using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class UserCred
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public UserCred() { }
        public UserCred(int UserId, string Login, string Role)
        {
            this.UserId = UserId;
            this.Login = Login;
            this.Role = Role;
        }
    }
}