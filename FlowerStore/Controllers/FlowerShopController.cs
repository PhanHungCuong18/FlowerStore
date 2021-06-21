using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerStore.Controllers
{
    public class FlowerShopController : Controller
    {
        // GET: FlowerShop
        public ActionResult Index()
        {
            return View();
        }
    }
}