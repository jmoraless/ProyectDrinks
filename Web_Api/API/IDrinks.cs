using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web_Api.Objet;

namespace Web_Api.API
{
    public interface IDrinks
    {
        Task<DrinksObj> GetDrinks(string search);
    }    
}