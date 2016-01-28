using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosModel.Model
{
    public class MensajeModel
    {
        public int id { get; set; }
        public int idOrigen { get; set; }
        public int idDestino { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public bool Leido { get; set; }
        //Mientras mantengas la base del model, se pueden añadir los campos extra que se quieran.
        //Por ejemplo en este caso se añade un campo mas para que según lo que muestre leido (true/false)
        //muestr un texto mas adecuado, que se llama en el listview
        //public String Estado
        //{
        //    get
        //    {
        //        if (Leido)
        //        {
        //            return "Leido";
        //        }
        //        else
        //        {
        //            return "Sin Leer";
        //        }
        //    }
        //}
        public String Estado => Leido ? "Leido" : "Sin Leer";
        public DateTime Fecha { get; set; }
    }
}
