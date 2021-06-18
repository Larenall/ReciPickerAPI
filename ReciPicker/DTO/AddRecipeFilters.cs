using ReciPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.DTO
{
    public class AddRecipeFilters
    {
        public string Type { get; set; }
        public FilterInfo Filters { get; set; }

        public AddRecipeFilters(string Type, FilterInfo Filters)
        {
            this.Type = Type;
            this.Filters = Filters;
        }
        public AddRecipeFilters()
        {

        }
    }
}
