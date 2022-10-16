using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zodiaco.Models
{
    public class Usuario
    {        
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Domicilio { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public int Cp { get; set; }            
        public Int64 Telefono { get; set; }
        public string Sexo { get; set; }
        public string FechaNac { get; set; }
        public string TipoUsuario { get; set; }

    }
}