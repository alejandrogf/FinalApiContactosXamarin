using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Adapter;

namespace ApiContactos.Adapters
{
   public  class UsuarioAdapter:BaseAdapter<Usuario,UsuarioModel>
    {
       public override Usuario FromViewModel(UsuarioModel model)
       {
           return new Usuario()
           {
            id   = model.id,
            Foto = model.Foto,
            Login = model.Login,
            Apellidos = model.Apellidos,
            Nombre = model.Nombre,
            Password = model.Password
           };
       }

       public override UsuarioModel FromModel(Usuario model)
       {
            return new UsuarioModel()
            {
                id = model.id,
                Foto = model.Foto,
                Login = model.Login,
                Apellidos = model.Apellidos,
                Nombre = model.Nombre,
                Password = model.Password
            };
        }
    }
}
