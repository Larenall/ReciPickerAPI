using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class UserChangeRoleDTO
    {
        public int UserId{get;set;}
        public string Role { get; set; }
        public UserChangeRoleDTO(int UserId, string Role)
        {
            this.UserId = UserId;
            this.Role = Role;
        }
        public UserChangeRoleDTO() { }
    }
}

