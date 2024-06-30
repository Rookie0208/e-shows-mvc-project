using e_shows.Data.Services;
using e_shows.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_shows.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService service;

        public ActorController(IActorService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = service.GetActors();
            return View(data);
        }
    }
}
