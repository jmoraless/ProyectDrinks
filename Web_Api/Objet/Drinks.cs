using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api.Objet
{
    public class DrinksObj
    {
        public List<drinks> drinks { get; set; }
    }

    public class drinks
    {
        public string strGlass { get; set; }
        public string strDrink { get; set; }
        public string idDrink { get; set; }
        public string strCategory { get; set; }
        public string strDrinkThumb { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
    }
}