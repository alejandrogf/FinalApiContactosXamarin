using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ApiContactos.Adapters;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;

namespace ApiContactos.Repositorios
{
    //Se crea un repositorio para cada conjunto de operaciones comunes a un model
    //El repositorio es invocado desde el controlador
    public class MensajeRepositorio : BaseRepositorioEntity<Mensaje, MensajeModel, MensajeAdapter>
    {
        public MensajeRepositorio(DbContext context) : base(context)
        {
        }

        //Obtener todos los mensajes enviados
        public ICollection<MensajeModel> GetByDestiny(int idDestino)
        {
            var data = Get(o => o.idDestino == idDestino).OrderByDescending(o=>o.Fecha);
            return data.ToList();
        }

        //Obtener todos los mensajes enviados
        public ICollection<MensajeModel> GetByOrigen(int idOrigen)
        {
            var data = Get(o => o.idOrigen == idOrigen).OrderByDescending(o => o.Fecha);
            return data.ToList();
        }
    }
}