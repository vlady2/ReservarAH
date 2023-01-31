using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReservaAH.DAL;

namespace ReservaAH.BL
{
    public class Conexion_BL
    {
        Conexion con = new Conexion();
        public string conexionSQL()
        {
            return con.ConexionSQL();
        }
    }
}