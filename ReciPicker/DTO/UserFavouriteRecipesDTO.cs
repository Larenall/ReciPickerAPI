using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.DTO
{
    public partial class UserFavouriteRecipesDTO
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }

        public UserFavouriteRecipesDTO(int RecipeId, int UserId)
        {
            this.RecipeId = RecipeId;
            this.UserId = UserId;
        }

    }
}
