using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketWeb.Models;

namespace RocketWeb.Controllers
{
    public class RocketController : Controller
    {
        // GET: RocketController
        public ActionResult Index()
        {
            return View(new Rocket { Id = 1, Name = "SpaceX-Rocket", Description = "Space Rocket by SpaceX" });
        }

    }
}
