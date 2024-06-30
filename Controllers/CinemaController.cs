using e_shows.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shows.Controllers
{
    public class CinemaController : Controller
    {
        private readonly eshowsContext context;

        public CinemaController(eshowsContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas = await context.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
