using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Web_Api.API;
using Web_Api.Objet;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            IDrinks getAlDrinks = new AllDrinks();
            InyectAPI inyeccionAPI = new InyectAPI(getAlDrinks);
            DrinksObj model = await inyeccionAPI.GetCoctels("");
            return View(model);
        }

        public async Task<PartialViewResult> CoctelsByName(string name)
        {
            IDrinks getDrinksByName = new DrinksByName();
            InyectAPI inyeccionAPI = new InyectAPI(getDrinksByName);
            DrinksObj model = await inyeccionAPI.GetCoctels(name);

            return PartialView(model);
        }

        public async Task<PartialViewResult> CoctelsByIngredent(string ingredent)
        {
            IDrinks getDrinksByIngredent = new DrinksByIngredent();
            InyectAPI inyeccionAPI = new InyectAPI(getDrinksByIngredent);
            DrinksObj model = await inyeccionAPI.GetCoctels(ingredent);

            return PartialView(model);
        }

        public async Task<PartialViewResult> DetailCoctel(string id) 
        {
            IDrinks getDetail = new DetailDrink();
            InyectAPI inyeccionAPI = new InyectAPI(getDetail);
            DrinksObj model = await inyeccionAPI.GetCoctels(id);

            return PartialView(model);
        }

        public ActionResult Favorite()
        {
            return View();
        }
    }
}
