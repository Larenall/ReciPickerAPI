using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReciPicker.Models;
using ReciPicker.DTO;

namespace ReciPicker.Helper
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(UserDTO user, List<User> list);
    }
}
