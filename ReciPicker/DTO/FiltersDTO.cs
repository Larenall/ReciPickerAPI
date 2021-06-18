using ReciPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReciPicker.DTO
{
    public class FiltersDTO
    {
        
        public string Type { get; set; }
        public List<FilterInfo> Filters { get; set; }

        public FiltersDTO(string Type, List<FilterInfo> Filters)
        {
            this.Type = Type;
            this.Filters = Filters;
        }
        public FiltersDTO()
        {

        }
    }
   
}
