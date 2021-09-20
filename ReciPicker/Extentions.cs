using ReciPicker.DTO;
using ReciPicker.Models;
using System;

namespace ReciPicker
    {
    public static class Extentions
    {
        public static UserFavouriteRecipes asModel (this UserFavouriteRecipesDTO ufr)
        {
            return new UserFavouriteRecipes(ufr.Id, ufr.RecipeId, ufr.UserId);
        }
    }
}