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
    public class ContactoAdapter:BaseAdapter<Usuario, ContactoModel>
    {
        //Cuando la clase es una tabla de n:n, que no existe en el model,
        //se puede hacer dejando el adapter en blanco

        //Recupera un usuario según el contacto que nos den

        public override Usuario FromViewModel(ContactoModel model)
        {
            return null;
        }

        public override ContactoModel FromModel(Usuario model)
        {
            return null;
        }
    }
}
