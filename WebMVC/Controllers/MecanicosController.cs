using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        [HttpGet]
        public ActionResult MecanicosDetail(string tipoDocumento, int? documento)
        {
            if (!string.IsNullOrEmpty(tipoDocumento) && documento.HasValue && documento.Value > 0)
            {
                List<WCFMecanicos.TMecanicos> listaMecanicos = new List<WCFMecanicos.TMecanicos>();
                WCFMecanicos.MecanicosClient wcfMecanicos = new MecanicosClient();

                listaMecanicos = wcfMecanicos.ConsultarMecanicos().Where(x => x.Tipo_Documento.Equals(tipoDocumento) && x.Documento.Equals(documento.Value)).ToList();

                WebMVC.Models.EditMecanicos mecanico = new WebMVC.Models.EditMecanicos();

                mecanico.Documento = listaMecanicos[0].Documento;
                mecanico.Tipo_Documento = listaMecanicos[0].Tipo_Documento;
                mecanico.Primer_Nombre = listaMecanicos[0].Primer_Nombre;
                mecanico.Segundo_Apellido = listaMecanicos[0].Segundo_Apellido;
                mecanico.Segundo_Nombre = listaMecanicos[0].Segundo_Nombre;
                mecanico.Celular = listaMecanicos[0].Celular;
                mecanico.Direccion = listaMecanicos[0].Direccion;
                mecanico.Email = listaMecanicos[0].Email;

                return View(mecanico);
            }
            //return Json(Respuesta, JsonRequestBehavior.AllowGet);
            return View();
        }

        [HttpPost]
        public ActionResult MecanicosDetail(WebMVC.Models.EditMecanicos mecanico)
        {
            string url = ConfigurationManager.AppSettings.Get("WebApiURL")+"mecanicos";

            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = JsonConvert.SerializeObject(mecanico, Formatting.Indented);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return View();
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        
                        Console.WriteLine(responseBody);
                    }
                }
            }



            return RedirectToAction("Index");
        }
            //return Json(Respuesta, JsonRequestBehavior.AllowGet);
    }


}
