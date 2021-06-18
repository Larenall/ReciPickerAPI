﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class SendRegisterUser
    {
        public int UserID{ get; set; }
        public string Login { get; set; }
        public bool IsLoginTaken {get;set;}
        public bool IsEmailTaken { get; set; }
        public string Role { get; set; }
        public List<int> UserFavourite { get; set; }
        public SendRegisterUser(int UserID,string Login,bool IsLoginTaken, bool IsEmailTaken,string Role,List<int> UserFavourite)
        {
            this.UserID = UserID;
            this.Login = Login;
            this.IsLoginTaken = IsLoginTaken;
            this.IsEmailTaken = IsEmailTaken;
            this.Role = Role;
            this.UserFavourite = UserFavourite;
        }
    }
}
