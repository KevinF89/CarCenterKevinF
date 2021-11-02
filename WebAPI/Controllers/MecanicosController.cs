using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebAPI.Models;
using WebAPI.Models.Mecanicos;
using Business.Logic;
using WebAPI.MappingExtensions;
using System.Web.Http.Description;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MecanicosController : ApiController
    {

        private MecanicosService mecanicosService = new MecanicosService();


        // GET: api/Mecanicos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mecanicos
        [HttpPost]
        public IHttpActionResult Post([FromBody]CreateMecanicos model)
        {
            if (ModelState.IsValid)
            {
                bool inserResult = this.mecanicosService.CreateMecanico(model.ToEntity());

            
                return this.Ok(
                    new Response<bool>
                    {
                        Data = inserResult,
                        Valido = inserResult
                    });
            }
            else 
            {
                return this.BadRequest(ModelState);
            }
        }

        // PUT: api/Mecanicos/5
        [HttpPut]
        public IHttpActionResult Put([FromBody]UpdateMecanicos model)
        {
            if (ModelState.IsValid)
            {
                bool updateResult = this.mecanicosService.UpdateMecanico(model.ToEntity());


                return this.Ok(
                    new Response<bool>
                    {
                        Data = updateResult,
                        Valido = updateResult
                    });
            }
            else
            {
                return this.BadRequest(ModelState);
            }
        }

        // DELETE: api/Mecanicos/5
        [HttpDelete]
        public IHttpActionResult Delete(string tipoDocumento, int documento)
        {
            if (ModelState.IsValid)
            {
                bool updateResult = this.mecanicosService.DeleteMecanico(tipoDocumento: tipoDocumento, documento: documento);


                return this.Ok(
                    new Response<bool>
                    {
                        Data = updateResult,
                        Valido = updateResult
                    });
            }
            else
            {
                return this.BadRequest(ModelState);
            }
        }
    }
}
