using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using zodiaco.Models;

namespace zodiaco.Services
{
    public class GuardarUsuarioServices
    {
        public string guardarUsuario(Usuario usuario)
        {

            Array userData = null;

            var dataFile = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            int existencia = 0;
            string mensaje = "";
            var matricula = Guid.NewGuid().ToString();
            var nombre = usuario.Nombre;
            var apellidos = usuario.Apellidos;
            var userName = usuario.UserName;
            var password = usuario.Password;
            var direccion = usuario.Calle+" #"+ usuario.Numero+" "+ usuario.Colonia+" C.P "+ usuario.Cp;            
            var telefono = usuario.Telefono;
            var sexo = usuario.Sexo;
            var fechaNac = usuario.FechaNac;
            var tipoUsuario = usuario.TipoUsuario;


            if (File.Exists(dataFile))
            {
                userData = File.ReadAllLines(dataFile);

                foreach (string item in userData)
                {
                    foreach (string usuarioR in item.Split(','))
                    {
                        if (usuarioR == usuario.UserName)
                        {
                            existencia = 1;
                        }
                        
                    }

                }

                if (existencia == 0)
                {
                    var datos = matricula + "," + nombre + "," + apellidos + "," + direccion + "," + telefono +
                     "," + sexo + "," + fechaNac + "," + userName + "," + password + "," + tipoUsuario + Environment.NewLine;
                    var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");



                    File.AppendAllText(@archivo, datos);

                    return mensaje = "Se registro correctamente";

                } else {
                    return mensaje ="ya existe este usuario";                                    
                }

                

            }else{
                File.AppendAllText(@dataFile,null);

                userData = File.ReadAllLines(dataFile);

                foreach (string item in userData)
                {
                    foreach (string usuarioR in item.Split(','))
                    {
                        if (usuarioR == usuario.UserName)
                        {
                            existencia = 1;
                        }

                    }

                }

                if (existencia == 0)
                {
                    var datos = matricula + "," + nombre + "," + apellidos + "," + direccion + "," + telefono +
                     "," + sexo + "," + fechaNac + "," + userName + "," + password + "," + tipoUsuario + Environment.NewLine;
                    var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");



                    File.AppendAllText(@archivo, datos);

                    return mensaje = "Se registro correctamente";

                }
                else
                {
                    return mensaje = "ya existe este usuario";
                }
            }                     
        }
    }
}