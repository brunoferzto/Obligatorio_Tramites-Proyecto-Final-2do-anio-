using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;

public partial class RegistroUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void BtnAlta_Click(object sender, EventArgs e)
    {
        try
        {
            LblError.Text = "";
            Solicitante sol = new Solicitante();
            sol.Contraseña = TxtPass.Text.Trim();
            sol.Nombre = TxtNomComp.Text.Trim();
            sol.Telefono = TxtTel.Text.Trim();
            try
            {
                sol.Cedula = Convert.ToInt32(TxtDocumento.Text.Trim());

            }
            catch
            {
                LblError.Text = "La Cédula no es valida";
                return;
            }
            Empleado emp = null;
            new ServicioClient().AltaUsuario(sol, emp);

            LblError.Text = "Alta con Exito";
            TxtPass.Text = "";
            TxtDocumento.Text = "";
            TxtNomComp.Text = "";
            TxtTel.Text ="";

        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
}