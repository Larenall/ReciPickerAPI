using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class RecipeDTO
    {
        public int Userid { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Time { get; set; }
        public string RecipeDescr { get; set; }
        public string RecipeIngr { get; set; }
        public List<RecipeFiltersDTO> Filters { get; set; }
        public RecipeDTO(int UserID,string Name, string ImgUrl, int Time, string RecipeDescr, string RecipeIngr, List<RecipeFiltersDTO> Filters)
        {
            this.Userid = UserID;
            this.Name = Name;
            this.ImgUrl = ImgUrl;
            this.Time = Time;
            this.RecipeDescr = RecipeDescr;
            this.RecipeIngr = RecipeIngr;
            this.Filters = Filters;
        }
        public RecipeDTO() { }
    }
}
