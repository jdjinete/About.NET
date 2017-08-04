using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WCFServiceClient;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ServiceClienteClient a = new ServiceClienteClient();
            ViewBag.Message = "Your contact is with: "+a.selectCliente().ToList().First().Nombre;

            return View();
        }
    }
}