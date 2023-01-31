using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReservaAH.EN;
using ReservaAH.BL;

namespace ReservaAH
{
    public partial class LogAd : System.Web.UI.Page
    {
        Usuarios us = new Usuarios();
        Usuarios_BL bl = new Usuarios_BL();
        //Mant_Usuarios mant = new Mant_Usuarios();
        public static string email1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            us.Correo_Usu = txtusuario.Text;
            email1 = txtusuario.Text;
            us.Contra_Usu = txtcontra.Text;
            try
            {
                bool resultado = bl.logIn_Usuarios(us);
                if (resultado == true)
                {
                    Response.Redirect("Mant_Usuarios.aspx");
                }
                else
                {
                    Response.Redirect("LogAd.aspx");
                }
            }
            catch (Exception ex) 
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}