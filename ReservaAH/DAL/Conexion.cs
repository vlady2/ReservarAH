using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservaAH.DAL
{
    public class Conexion
    {
        public string ConexionSQL()
        {
            string respuesta = "";
            try
            {
                //PInfos
                //pr_CitasOnline
                //respuesta = @"Data Source = LAPTOP - JIMR5AJ2\SQLEXPRESS; Initial Catalog = DBReservaAH; User ID = sa; Password = VL97vi19+ ";
                respuesta = @"Data Source=LAPTOP-JIMR5AJ2\SQLEXPRESS;Initial Catalog=DBReservaAH;User ID=sa;Password=VL97vi19+";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return respuesta;
        }
    }
}