using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class OutUserSignInDTO
    {
        public int UserID { get; set; }

        public string Login { get; set; }
        public bool UserExists { get;set;}
        public bool IsPasswordCorrect { get; set; }
        public string Role { get; set; }
        public List<int> UserFavourite { get; set; }
        public OutUserSignInDTO(int UserID,string Login,bool UserExists, bool IsPasswordCorrect, string Role, List<int> UserFavourite)
        {
            this.UserID = UserID;
            this.Login = Login;
            this.UserExists = UserExists;
            this.IsPasswordCorrect = IsPasswordCorrect;
            this.Role = Role;
            this.UserFavourite = UserFavourite;

        }
        public OutUserSignInDTO(bool UserExists, bool IsPasswordCorrect)
        {
            this.UserExists = UserExists;
            this.IsPasswordCorrect = IsPasswordCorrect;
        }
        public OutUserSignInDTO() { }
    }
}
