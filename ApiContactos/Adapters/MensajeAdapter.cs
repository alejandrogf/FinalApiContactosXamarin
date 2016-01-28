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
    //Para cada entidad (tabla de bbdd) que queremos manejar hay que crear un adapter.
    public class MensajeAdapter:BaseAdapter<Mensaje, MensajeModel>
        //Se pone mensaje y mensajemodel porque al crear la interfaz se definió así, 
        //indicando que base adapter recibe tentity que es la clase de bbdd y 
        //segundo argumento tmodel que es el modelo de datos en el dispòsitibo movil 
        //(el transfer object que nosotros llamamos viewmodel
    {
        public override Mensaje FromViewModel(MensajeModel model)
        {
            return new Mensaje()
            {
                id=model.id,
                idDestino = model.idDestino,
                idOrigen = model.idOrigen,
                Asunto = model.Asunto,
                Fecha=model.Fecha,
                Leido = model.Leido,
                Contenido=model.Asunto
            };
        }

        public override MensajeModel FromModel(Mensaje model)
        {
            return new MensajeModel()
            {
                id = model.id,
                idDestino = model.idDestino,
                idOrigen = model.idOrigen,
                Asunto = model.Asunto,
                Fecha = model.Fecha,
                Leido = model.Leido,
                Contenido = model.Asunto
            };
        }
    }
}
