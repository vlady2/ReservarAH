using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReservaAH.EN;
using ReservaAH.BL;
using System.Data;
using System.Data.SqlClient;

namespace ReservaAH.DAL
{
    public class Usuarios_DAL
    {
        Conexion_BL conbl = new Conexion_BL();
        SqlConnection con;
        IDataReader reader;
        List<Usuarios> list;
        public bool Crub_Usuario(Usuarios en)
        {
            string conn = conbl.conexionSQL();
            try
            {
                con = new SqlConnection(conn);
                object res;
                con.Open();
                SqlCommand cmd = new SqlCommand("Crub_Usuarios", con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@opcion", en.Opcion);
                cmd.Parameters.AddWithValue("@Id_Usu", en.Id_Usu);
                cmd.Parameters.AddWithValue("@Correo_Usu", en.Correo_Usu);
                cmd.Parameters.AddWithValue("@Contra_Usu", en.Contra_Usu);
                cmd.Parameters.AddWithValue("@Avatar_Usu", en.Avatar_Usu);
                cmd.Parameters.AddWithValue("@Id_Rol", en.Id_Rol);
                cmd.CommandTimeout = 1;
                res = cmd.ExecuteScalar();
                bool boolena = res == null ? false : (bool)res;
                if (boolena != true & cmd.CommandTimeout >= 1) { con.Close(); }
                return true;
            }
            catch (Exception ex)
            {
                if (con != null) { con.Close(); }
                return false;
            }
        }
        public List<Usuarios> Get_Usuarios(string correo)
        {
            string conn = conbl.conexionSQL();
            try
            {
                con = new SqlConnection(conn);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Get_Usuarios", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Correo_Usu", correo);
                reader = da.SelectCommand.ExecuteReader();
                list = new List<Usuarios>();
                while (reader.Read())
                {
                    Usuarios en = new Usuarios
                    {
                        Id_Usu = reader.GetInt64(0),
                        Correo_Usu = reader.GetString(1),
                        Contra_Usu = reader.GetString(2),
                        Avatar_Usu = reader.GetString(3),
                        Id_Rol = reader.GetInt32(4)
                    };
                    list.Add(en);
                }
                reader.Close();
                con.Close();
                return list;
            }
            catch
            {
                if (con != null)
                {
                    con.Close();
                }
                return null;
            }
        }
        public bool logIn_Usuarios(Usuarios us)
        {
            string conn = conbl.conexionSQL();
            try
            {
                con = new SqlConnection(conn);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("LogIn_Usuarios", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Correo_Usu", us.Correo_Usu);
                da.SelectCommand.Parameters.AddWithValue("@Contra_Usu", us.Contra_Usu);
                reader = da.SelectCommand.ExecuteReader();
                list = new List<Usuarios>();
                while (reader.Read())
                {
                    Usuarios en = new Usuarios
                    {
                        Id_Usu = reader.GetInt64(0),
                        Correo_Usu = reader.GetString(1),
                        Contra_Usu = reader.GetString(2),
                        Avatar_Usu = reader.GetString(3),
                        Id_Rol = reader.GetInt32(4)
                    };
                    list.Add(en);
                }
                reader.Close();
                con.Close();
                if (list.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception  ex)
            {
                if (con != null)
                {
                    con.Close();
                    ex.ToString();
                }
                return false;
            }
        }
    }
}