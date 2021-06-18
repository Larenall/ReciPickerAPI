using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class RecipeDetails
    {
        public int RecipeId { get; set; }
        public string Info { get; set; }
        public string Method { get; set; }
        public int Id { get; set; }

        public RecipeDetails(int recipeId, string info, string method)
        {
            RecipeId = recipeId;
            Info = info;
            Method = method;
        }
    }
}
