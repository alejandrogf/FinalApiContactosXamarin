using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiContactos.Repositorios;
using ContactosModel.Model;
using Microsoft.Practices.Unity;

namespace ApiContactos.Controllers
{
    //De tipo web api controller EMPTY
    public class MensajeController : ApiController
    {
        [Dependency]
        public MensajeRepositorio MensajeRepositorio { get; set; }

        public ICollection<MensajeModel> Get(int id)
        {
            return MensajeRepositorio.GetByDestino(id);
        }

        public ICollection<MensajeModel> Get(int id, bool enviado)
        {
            return MensajeRepositorio.GetByOrigen(id);
        }

        [ResponseType(typeof (MensajeModel))]
        public IHttpActionResult Post(MensajeModel model)
        {
            var data= MensajeRepositorio.Add(model);
            if (data==null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        //marcar como leido
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(MensajeModel model )
        {
            var data = MensajeRepositorio.Update(model);
            if (data<1)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
