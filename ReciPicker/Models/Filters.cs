using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class Filters
    {
        public int FilterId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
