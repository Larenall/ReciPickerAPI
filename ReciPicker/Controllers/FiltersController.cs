using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReciPicker.Models;
using ReciPicker.DTO;
using Microsoft.AspNetCore.Authorization;

namespace ReciPicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private readonly recipickerContext db;

        public FiltersController(recipickerContext context)
        {
            db = context;
        }

        [HttpGet]
        [Authorize]
        public List<FiltersDTO> GetFilters()
        {
            var filters = db.Filters.OrderBy(el => el.Name).ToList().
                GroupBy(f => f.Type, f => new FilterInfo(f.FilterId, f.Name), (fType, info) => new FiltersDTO(fType, info.ToList())).
                OrderBy(el => el.Type).ToList();
            return filters;
        }
    }
}
