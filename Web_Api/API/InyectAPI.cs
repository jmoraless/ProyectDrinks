using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web_Api.Objet;

namespace Web_Api.API
{
    public class InyectAPI
    {
        IDrinks drinks;

        public InyectAPI(IDrinks _drinks)
        {
            drinks = _drinks;
        }

        public async Task<DrinksObj> GetCoctels(string search)
        {
            return await drinks.GetDrinks(search);
        }
    }
}