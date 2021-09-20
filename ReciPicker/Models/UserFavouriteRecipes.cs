using System;
using System.Collections.Generic;


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
        public UserFavouriteRecipes(int Id, int RecipeId, int UserId)
        {
            this.Id = Id;
            this.RecipeId = RecipeId;
            this.UserId = UserId;
        }

    }
}
