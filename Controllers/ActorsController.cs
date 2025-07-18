using ecommerce_mvc.Data;
using ecommerce_mvc.Data.Services;
using ecommerce_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_mvc.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;  // In

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictueURL,Bio")] Actor actor)
        {
            //actor.Actors_Movies = [];

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/Id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
