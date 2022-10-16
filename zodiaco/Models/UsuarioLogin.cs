using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zodiaco.Models
{
    public class UsuarioLogin
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

        public string Edad { get; set; }

        public string Signo { get; set; }


        public UsuarioLogin(string nombre, string apellidos, string userName, string password, 
            string domicilio, Int64 telefono, string sexo, string fechaNac, string tipoUsuario)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.UserName = userName;
            this.Password = password;
            this.Domicilio = domicilio;
            this.Telefono = telefono;
            this.Sexo = sexo;
            this.FechaNac = fechaNac;
            this.TipoUsuario = tipoUsuario;
            

            string[] fecha = fechaNac.Split('-');
            DateTime nacimiento = new DateTime(int.Parse(fecha[0]), int.Parse(fecha[1]), int.Parse(fecha[2])); //Fecha de nacimiento
            this.Edad = "" + (DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1);

            if ((int.Parse(fecha[2]) >= 21 && int.Parse(fecha[1]) == 3) || (int.Parse(fecha[2]) <= 20 && int.Parse(fecha[1]) == 4))
                this.Signo="Aries";
            if ((int.Parse(fecha[2]) >= 24 && int.Parse(fecha[1]) == 9) || (int.Parse(fecha[2]) <= 23 && int.Parse(fecha[1]) == 10))
                this.Signo = "Libra";
            if ((int.Parse(fecha[2]) >= 21 && int.Parse(fecha[1]) == 4) || (int.Parse(fecha[2]) <= 21 && int.Parse(fecha[1]) == 5))
                this.Signo = "Tauro";
            if ((int.Parse(fecha[2]) >= 24 && int.Parse(fecha[1]) == 10) || (int.Parse(fecha[2]) <= 22 && int.Parse(fecha[1]) == 11))
                this.Signo = "Escorpio";
            if ((int.Parse(fecha[2]) >= 22 && int.Parse(fecha[1]) == 5) || (int.Parse(fecha[2]) <= 21 && int.Parse(fecha[1]) == 6))
                this.Signo = "Geminis";
            if ((int.Parse(fecha[2]) >= 23 && int.Parse(fecha[1]) == 11) || (int.Parse(fecha[2]) <= 21 && int.Parse(fecha[1]) == 12))
                this.Signo = "Sagitario";
            if ((int.Parse(fecha[2]) >= 21 && int.Parse(fecha[1]) == 6) || (int.Parse(fecha[2]) <= 23 && int.Parse(fecha[1]) == 7))
                this.Signo = "Cancer";
            if ((int.Parse(fecha[2]) >= 22 && int.Parse(fecha[1]) == 12) || (int.Parse(fecha[2]) <= 20 && int.Parse(fecha[1]) == 1))
                this.Signo = "Capricornio";
            if ((int.Parse(fecha[2]) >= 24 && int.Parse(fecha[1]) == 7) || (int.Parse(fecha[2]) <= 23 && int.Parse(fecha[1]) == 8))
                this.Signo = "Leo";
            if ((int.Parse(fecha[2]) >= 21 && int.Parse(fecha[1]) == 1) || (int.Parse(fecha[2]) <= 19 && int.Parse(fecha[1]) == 2))
                this.Signo = "Acuario";
            if ((int.Parse(fecha[2]) >= 24 && int.Parse(fecha[1]) == 8) || (int.Parse(fecha[2]) <= 23 && int.Parse(fecha[1]) == 9))
                this.Signo = "Virgo";
            if ((int.Parse(fecha[2]) >= 20 && int.Parse(fecha[1]) == 2) || (int.Parse(fecha[2]) <= 20 && int.Parse(fecha[1]) == 3))
                this.Signo = "Piscis";
        }

        public void edad()
        {
          
        }
    }
}