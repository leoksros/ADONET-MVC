using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADONETMVC.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string clave { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }

    }
}