using ReciPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class RecipeFiltersDTO
    {
        public string Type { get; set; }
        public FilterDTO Filters { get; set; }

        public RecipeFiltersDTO(string Type, FilterDTO Filters)
        {
            this.Type = Type;
            this.Filters = Filters;
        }
        public RecipeFiltersDTO()
        {

        }
    }
}
