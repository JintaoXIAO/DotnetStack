using DependencyInjectionSample.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;
        private IEnumerable<IMyDependency> _myDependencys;

        public IndexModel(RazorPagesMovieContext context, IEnumerable<IMyDependency> myDependencys)
        {
            _myDependencys = myDependencys;

            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        
        public SelectList? Genres { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
        
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                select m;

            var genres = from m in _context.Movie
                orderby m.Genre
                select m.Genre;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(m => m.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(m => m.Genre == MovieGenre);
            }

            foreach (var myDependency in _myDependencys)
            {
                myDependency.WriteMessage($">>>> you accessed Index page");
            }
            
            Genres = new SelectList(await genres.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
