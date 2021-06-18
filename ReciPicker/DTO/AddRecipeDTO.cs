using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class AddRecipeDTO
    {
        public int Userid { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Time { get; set; }
        public string RecipeDescr { get; set; }
        public string RecipeIngr { get; set; }
        public List<AddRecipeFilters> Filters { get; set; }
        public AddRecipeDTO(int UserID,string Name, string ImgUrl, int Time, string RecipeDescr, string RecipeIngr, List<AddRecipeFilters> Filters)
        {
            this.Userid = UserID;
            this.Name = Name;
            this.ImgUrl = ImgUrl;
            this.Time = Time;
            this.RecipeDescr = RecipeDescr;
            this.RecipeIngr = RecipeIngr;
            this.Filters = Filters;
        }
        public AddRecipeDTO() { }
    }
}
