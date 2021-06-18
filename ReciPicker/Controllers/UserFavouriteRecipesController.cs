using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciPicker.Models;
using ReciPicker.DTO;

namespace ReciPicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFavouriteRecipesController : ControllerBase
    {
        private readonly recipickerContext db;

        public UserFavouriteRecipesController(recipickerContext context)
        {
            db = context;
        }

        
        [HttpPost]
        public  void AddFavorite(UserFavouriteRecipes data)
        {
            db.UserFavouriteRecipes.Add(data);
            db.SaveChanges();
        }
        [HttpDelete]
        public void RemoveFavourite(UserFavouriteRecipesDTO data)
        {
            UserFavouriteRecipes favouriteRecipe = db.UserFavouriteRecipes.FirstOrDefault(el => el.RecipeId == data.RecipeId && el.UserId == data.UserId);
            db.UserFavouriteRecipes.Remove(favouriteRecipe);
            db.SaveChanges();
        }


    }
}
