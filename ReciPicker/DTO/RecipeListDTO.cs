using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.DTO
{
    public partial class RecipeListDTO
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public int Time { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? IsApproved { get; set; }
        public List<int> Filters { get; set; }
        public string Info { get; set; }
        public string Method { get; set; }

        public RecipeListDTO(int RecipeId,int UserId,string Name,string ImgUrl,int Time, DateTime? AddDate,bool? IsApproved,List<int> Filters,string Info,string Method)
        {
            this.RecipeId = RecipeId;
            this.UserId = UserId;
            this.Name = Name;
            this.ImgUrl = ImgUrl;
            this.Time=Time;
            this.IsApproved = IsApproved;
            this.Filters = Filters;
            this.AddDate = AddDate;
            this.Info = Info;
            this.Method = Method;
        }
        public RecipeListDTO() { }
    }
}
