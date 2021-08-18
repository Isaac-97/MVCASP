using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiseñandoFront.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult Index()
        {
            var myView = View();
            myView.MasterName = "~/Views/Shared/_Layout.cshtml";
            return myView;
        }
    }
}