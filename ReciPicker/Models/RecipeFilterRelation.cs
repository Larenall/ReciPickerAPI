using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class RecipeFilterRelation
    {
        

        public int RecipeId { get; set; }
        public int FilterId { get; set; }
        public bool? IsChecked { get; set; }
        public int Id { get;  set; }

        public RecipeFilterRelation(int recipeId, int filterId, bool? IsChecked)
        {
            RecipeId = recipeId;
            FilterId = filterId;
            this.IsChecked = IsChecked;
        }
    }
}
