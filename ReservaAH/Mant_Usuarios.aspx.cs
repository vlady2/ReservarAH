using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReservaAH.BL;
using ReservaAH.EN;

namespace ReservaAH
{
    public partial class Mant_Usuarios : System.Web.UI.Page
    {
        Usuarios en = new Usuarios();
        Usuarios_BL bl = new Usuarios_BL();
        bool respuesta;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDataUser();
            cargarGridView("All");
            limpiarControles();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                en.Opcion = 1;
                en.Correo_Usu = txtcorreo.Text;
                en.Contra_Usu = txtpasword.Text;
                en.Avatar_Usu = txtavatar.Text;
                en.Id_Usu = Convert.ToInt32(txtrol.Text);

                respuesta = bl.Crub_Usuario(en);

                Response.Write("<script>alert('"+respuesta+"')</script>");
                cargarGridView("All");
                limpiarControles();
            }
            catch
            {

            }

        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                en.Opcion = 2;
                en.Id_Usu = 3;
                en.Correo_Usu = txtcorreo.Text;
                en.Contra_Usu = txtpasword.Text;
                en.Avatar_Usu = txtavatar.Text;
                en.Id_Usu = Convert.ToInt32(txtrol.Text);

                respuesta = bl.Crub_Usuario(en);
                Response.Write("<script>alert('" + respuesta + "')</script>");
                cargarGridView("All");
                limpiarControles();
            }
            catch
            {
                Response.Write("<script>alert('" + respuesta + "')</script>");
            }
        }

        protected void btnaeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cargarGridView("All");
                limpiarControles();
            }
            catch
            {
                Response.Write("<script>alert('" + respuesta + "')</script>");
            }
        }

        public void cargarGridView(string variable)
        {
            try
            {
                this.gvUser.DataSource = bl.Get_Usuarios(variable);
                this.gvUser.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        public void cargarDataUser()
        {

            var list = bl.Get_Usuarios(LogAd.email1);
            pUser.Text = list[0].Correo_Usu;
            pImage.ImageUrl = list[0].Avatar_Usu;
        }
        public void limpiarControles()
        {
            txtcorreo.Text = "";
            txtpasword.Text = "";
            txtavatar.Text = "";
            txtrol.Text = "";
        }
    }
}