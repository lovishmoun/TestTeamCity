using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestTeamCity.Model;
using TestTeamCity.Models;

namespace TestTeamCity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TestTeamCity.Models.DataContext _context;

        public IndexModel(TestTeamCity.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
