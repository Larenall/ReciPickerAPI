using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.DTO
{
    public partial class RecipeFilters
    {
        public int RecipeId { get; set; }
        public List<int> Filters { get; set; }

        public RecipeFilters(int RecipeId, List<int> Filters)
        {
            this.RecipeId = RecipeId;
            this.Filters = Filters;

        }
        public RecipeFilters() { }
    }
}
