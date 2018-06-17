using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMovie_2.Models;

namespace RazorPagesMovie_2.Pages.Movies
{
    public class IndexModel : PageModel
    //indexModel, the razor page, is derived from the pageModel Class

    {
        private readonly RazorPagesMovie_2.Models.RazorPagesMovie_2Context _context;

        //Notice that for functions such as OnGet or OnGetAsync, no return clause is used

        public IndexModel(RazorPagesMovie_2.Models.RazorPagesMovie_2Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }


        // Here onGetAsync is used to get the list of all movies and display them
        // This is used to initialize the state of the page
        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
