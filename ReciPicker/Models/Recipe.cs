using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Time { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsApproved { get; set; }

        public Recipe(int UserId,string Name,string ImgUrl,int Time,bool? IsApproved)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.ImgUrl = ImgUrl;
            this.Time=Time;
            this.IsApproved = IsApproved;
        }
        public Recipe() { }
    }
}
