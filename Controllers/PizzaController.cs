using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }
        // GET: MenuPizze
        public IActionResult Index()
        {
            using(PizzaContext context = new PizzaContext())
            {
                List<Pizza> pizzaList = context.Pizzas.ToList();
                return View(pizzaList);

            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            using (PizzaContext context = new PizzaContext())
            {
                Pizza pizzaFound = context.Pizzas.Where(pizza => pizza.PizzaId == id).FirstOrDefault();

                if (pizzaFound == null)
                {
                    return NotFound($"La pizza con id {id} non è stato trovato");
                }
                else
                {
                    return View("Details", pizzaFound);
                }
            }
        }



    }
}
