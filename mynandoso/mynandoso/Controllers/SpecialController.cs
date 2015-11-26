using mynandoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mynandoso.Controllers
{
    public class SpecialController : ApiController
    {
        Special[] specials = new Special[]
       {
            new Special { Id = 1, Dishname = "Quarter Chicken", Category = "Flame-grilled", Price = 8 },
            new Special { Id = 2, Dishname = "Quarter Chicken & Regular side", Category = "Flame-grilled", Price = 12 },
            new Special { Id = 3, Dishname = "Half Chicken", Category = "Flame-grilled", Price = 12 },
            new Special { Id = 4, Dishname = "Espetada Grande", Category = "Meals to Share", Price = 27 }
       };
     
        public IEnumerable<Special> GetAllSpecial()
        {
            return specials;
        }

    }
}
