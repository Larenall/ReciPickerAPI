using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciPicker.Models
{
    public class FilterDTO
    {
        public int FilterID { get; set; }
        public string Name { get; set; }
        public bool? Checked { get; set; }
        public FilterDTO(int FilterID, string Name)
        {
            this.FilterID = FilterID;
            this.Name = Name;
        }
        public FilterDTO()
        {
        }

        public FilterDTO(int filterID, string name, bool? @checked) : this(filterID, name)
        {
            Checked = @checked;
        }
    }
}
