using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Web_Api.Objet;

namespace Web_Api.API
{
    public class DrinksByName : IDrinks
    {
        public async Task<DrinksObj> GetDrinks(string name)
        {
            var model = new DrinksObj();
            string url = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + name;
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);

            model = JsonConvert.DeserializeObject<DrinksObj>(json);

            return model;
        }
    }

    public class AllDrinks : IDrinks
    {
        public async Task<DrinksObj> GetDrinks(string namei)
        {
            var model = new DrinksObj();
            string url = "https://www.thecocktaildb.com/api/json/v1/1/search.php?f=a";
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);

            model = JsonConvert.DeserializeObject<DrinksObj>(json);

            return model;
        }
    }

    public class DrinksByIngredent : IDrinks
    {
        public async Task<DrinksObj> GetDrinks(string namei)
        {
            var model = new DrinksObj();
            string url = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=" + namei;
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);

            model = JsonConvert.DeserializeObject<DrinksObj>(json);

            return model;
        }
    }

    public class DetailDrink : IDrinks
    {
        public async Task<DrinksObj> GetDrinks(string idDrink)
        {
            var model = new DrinksObj();
            string url = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=" + idDrink;
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);

            model = JsonConvert.DeserializeObject<DrinksObj>(json);

            return model;
        }
    }    
}