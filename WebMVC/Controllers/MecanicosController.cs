using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.WCFMecanicos;

namespace WebMVC.Controllers
{
    public class MecanicosController : Controller
    {
        // GET: Mecanicos
        public ActionResult Index()
        {
            List<WCFMecanicos.TMecanicos> lisaMecanicos = new List<WCFMecanicos.TMecanicos>();
            WCFMecanicos.MecanicosClient wcfMecanicos = new MecanicosClient();

            lisaMecanicos = wcfMecanicos.ConsultarMecanicos().ToList();

            //return Json(Respuesta, JsonRequestBehavior.AllowGet);
            return View(lisaMecanicos);
        }
    }
}