using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciPicker.Models;
using ReciPicker.DTO;
using Microsoft.AspNetCore.Authorization;

namespace ReciPicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecipesController : ControllerBase
    {
        private readonly recipickerContext db;

        public RecipesController(recipickerContext context)
        {
            db = context;
        }

        [HttpGet]
        public IEnumerable<RecipeListDTO> GetRecipes()
        {
            var recipeFilters =  db.RecipeFilterRelation.ToList().GroupBy(el => el.RecipeId, el => el.FilterId, (recipeId, filterId) => new RecipeFilters(recipeId, filterId.ToList())).ToList();
            var recipes = db.Recipes.ToList();
            List<RecipeListDTO> recipeDtoList = new List<RecipeListDTO>();
            recipes.ForEach(r => {
                var details = db.RecipeDetails.FirstOrDefault(d => d.RecipeId == r.RecipeId);
                recipeDtoList.Add(new RecipeListDTO(
                    r.RecipeId,
                    r.UserId,
                    r.Name,
                    r.ImgUrl,
                    r.Time,
                    r.AddDate,
                    r.IsApproved,
                    recipeFilters.FirstOrDefault(rf => rf.RecipeId == r.RecipeId).Filters ?? new List<int>(),
                    details.Info,
                    details.Method
                    ));
            });
            return recipeDtoList;
        }
        [HttpPost]
        public void AddRecipe(RecipeDTO recipeInfo)
        {
            var newRecipe = new Recipe(recipeInfo.Userid, recipeInfo.Name, recipeInfo.ImgUrl, recipeInfo.Time, false);
            db.Recipes.Add(newRecipe);
            db.SaveChanges();
            db.RecipeDetails.Add(new RecipeDetails(newRecipe.RecipeId, recipeInfo.RecipeDescr, recipeInfo.RecipeIngr));
            recipeInfo.Filters.ForEach(f => db.RecipeFilterRelation.Add(new RecipeFilterRelation(newRecipe.RecipeId, f.Filters.FilterID, f.Filters.Checked)));
            db.SaveChanges();
        }
        [HttpPatch]
        public void UpdateRecipe(RecipeListDTO recipeInfo)
        {
            var recipe = db.Recipes.FirstOrDefault(r => r.RecipeId == recipeInfo.RecipeId);
            var recipeDetails = db.RecipeDetails.FirstOrDefault(r => r.RecipeId == recipeInfo.RecipeId);
            recipe.Time = recipeInfo.Time;
            recipe.IsApproved = recipeInfo.IsApproved;
            recipeDetails.Info = recipeInfo.Info;
            recipeDetails.Method = recipeInfo.Method;
            db.Recipes.Update(recipe);
            db.RecipeDetails.Update(recipeDetails);
            db.SaveChanges();
        }
    }
}
