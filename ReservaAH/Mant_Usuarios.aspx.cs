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
        Int64 id = 0;
        bool CUpdate = false;
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
                if (CUpdate == false)
                {
                    en.Opcion = 1;
                    en.Correo_Usu = txtcorreo.Text;
                    en.Contra_Usu = txtpasword.Text;
                    en.Avatar_Usu = txtavatar.Text;
                    en.Id_Rol = Convert.ToInt32(txtrol.Text);
                }
                else
                {
                    en.Opcion = 2;
                    en.Id_Usu = id;
                    en.Correo_Usu = txtcorreo.Text;
                    en.Contra_Usu = txtpasword.Text;
                    en.Avatar_Usu = txtavatar.Text;
                    en.Id_Rol = Convert.ToInt32(txtrol.Text);
                }
                respuesta = bl.Crub_Usuario(en);
                if (respuesta == true)
                {
                    Response.Write("<script>alert('Usuario Guardado')</script>");
                    cargarGridView("All");
                    limpiarControles();
                    CUpdate = false;
                }
                else
                {
                    Response.Write("<script>alert('Error, Algo fallo en el salvado de la informacion')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        protected void gvUser_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                id = Convert.ToInt64(((GridView)sender).Rows[e.NewEditIndex].Cells[1].Text);
                txtcorreo.Text = ((GridView)sender).Rows[e.NewEditIndex].Cells[2].Text;
                txtpasword.Text = ((GridView)sender).Rows[e.NewEditIndex].Cells[3].Text;
                txtavatar.Text = ((GridView)sender).Rows[e.NewEditIndex].Cells[4].Text;
                txtrol.Text = ((GridView)sender).Rows[e.NewEditIndex].Cells[5].Text;
                CUpdate = true;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }
        protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                en.Opcion = 3;
                en.Id_Usu = Convert.ToInt32(((GridView)sender).Rows[e.RowIndex].Cells[1].Text);
                en.Correo_Usu = "";
                en.Contra_Usu = "";
                en.Avatar_Usu = "";
                en.Id_Rol = 1;

                respuesta = bl.Crub_Usuario(en);
                if (respuesta == true)
                {
                    Response.Write("<script>alert('Usuario eliminado')</script>");
                    cargarGridView("All");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
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