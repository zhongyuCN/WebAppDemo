using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppDemo.Data;
using WebAppDemo.Models;

namespace WebAppDemo.Views.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebAppDemo.Data.WebAppDemoContext _context;

        public IndexModel(WebAppDemo.Data.WebAppDemoContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
