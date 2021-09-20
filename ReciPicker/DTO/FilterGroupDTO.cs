using ReciPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReciPicker.DTO
{
    public class FilterGroupDTO
    {
        
        public string Type { get; set; }
        public List<FilterDTO> Filters { get; set; }

        public FilterGroupDTO(string Type, List<FilterDTO> Filters)
        {
            this.Type = Type;
            this.Filters = Filters;
        }
        public FilterGroupDTO()
        {

        }
    }
   
}
