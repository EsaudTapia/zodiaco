using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using zodiaco.Models;

namespace zodiaco.Services
{
    public class PerfilServices
    {

        public List<UsuarioLogin> leerPerfil(string userName)
        {
            var dataFile = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            List<UsuarioLogin> lista = new List<UsuarioLogin>();
            List<UsuarioLogin> listaf = new List<UsuarioLogin>();

            using (StreamReader sr = new StreamReader(dataFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infousu = line.Split(',');
                    UsuarioLogin usu = new UsuarioLogin(infousu[1], infousu[2],
                        infousu[7],
                        infousu[8], infousu[3], Int64.Parse(infousu[4]),
                        infousu[5], infousu[6], infousu[9]
                      );
                    usu.edad();
                    lista.Add(usu);
                }
            }

            foreach (var item in lista)
            {
                if (userName == item.UserName)
                {
                    
                    listaf.Add(item);
                }
            }
            return listaf;
        }

        }
}