using e_shows.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shows.Controllers
{
    public class ActorController : Controller
    {
        private readonly eshowsContext context;

        public ActorController(eshowsContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Actor.ToList();
            return View();
        }
    }
}
