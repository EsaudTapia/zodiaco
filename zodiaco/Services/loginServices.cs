using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web;
using zodiaco.Models;

namespace zodiaco.Services
{
    public class loginServices
    {
        public string login(Usuario usuario)
        {
            Array userData = null;
            string mensaje = "";
            string exitencia = "";
            int count = 0;
            var dataFile = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");                        
            List<UsuarioLogin> lista = new List<UsuarioLogin>();            
           
            if (File.Exists(dataFile))
            {
                //userData = File.ReadAllLines(dataFile);


                using (StreamReader sr = new StreamReader(dataFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] infousu = line.Split(',');
                        UsuarioLogin usu = new UsuarioLogin(infousu[1], infousu[2], 
                            infousu[7],
                            infousu[8],infousu[3], Int64.Parse(infousu[4]),
                            infousu[5], infousu[6], infousu[9]
                          );
                        lista.Add(usu);
                    }

                                 

                    foreach (UsuarioLogin usu in lista)
                    {
                        if (usu.UserName == usuario.UserName && usu.Password == usuario.Password)
                        {
                            exitencia = usu.UserName;
                            
                        }

                    }



                }
                



               


                if (exitencia == usuario.UserName )
                {
                    return mensaje = exitencia;
                }
                else
                {
                    return mensaje = "";
                }




            }
            else
            {
                return mensaje = "No existe la base de datos";

            }

        }
    }
}