using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;

public partial class Logueo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Solicitante"] = null;
    }

    protected void btnlogueo_Click(object sender, EventArgs e)
    {
        try
        {
            string contraseña = txtcontra.Text;
            int cedula = Convert.ToInt32(txtcedula.Text);
            Usuario sol = new ServicioClient().LogueoUsuario(contraseña, cedula);
            if (sol == null)
                LblError.Text = "Usuario o Contraseña invalidos";
            else
            {
                Session["Solicitante"] = sol;
                Response.Redirect("SolicitudTramite.aspx");
            }
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
}