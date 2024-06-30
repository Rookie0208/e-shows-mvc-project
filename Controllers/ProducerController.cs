using e_shows.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shows.Controllers
{
    public class ProducerController : Controller
    {
        private readonly eshowsContext context;

        public ProducerController(eshowsContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var producers = await context.Producer.ToListAsync();
            return View();
        }
    }
}
