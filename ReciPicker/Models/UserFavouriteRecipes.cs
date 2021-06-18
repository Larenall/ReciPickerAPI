using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class UserFavouriteRecipes
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int UserId { get; set; }

        public UserFavouriteRecipes()
        {

        }
        public UserFavouriteRecipes(int RecipeId, int UserId)
        {
            this.RecipeId = RecipeId;
            this.UserId = UserId;
        }

    }
}
