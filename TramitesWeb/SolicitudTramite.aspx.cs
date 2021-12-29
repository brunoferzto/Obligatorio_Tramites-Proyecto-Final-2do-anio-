using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  Servicio;
using System.Xml.Linq;
using System.Xml;

public partial class SolicitudTramite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Solicitante sol = (Solicitante)Session["Solicitante"];
                LblError.Text = "";

                string xmla = new ServicioClient().ListarTiposdeTramite(sol);

                XElement documento = XElement.Parse(xmla);

                var resultado = (from Nodo in documento.Elements("Tramite")
                                 select
                                 new
                                 {
                                     Tramite = Nodo.Element("Nombre").Value,
                                     Codigo = Nodo.Element("Codigo").Value
                                 }).ToList();
                GvTramites.DataSource = resultado;
                GvTramites.DataBind();
            }

        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
    protected void BtnSolicitar_Click(object sender, EventArgs e)
    {
        try
        {
            Solicitud sol = new Solicitud();
            Empleado emp = null;
            TiposdeTramite tra = new ServicioClient().BuscarTiposdeTramiteActivo(GvTramites.SelectedRow.Cells[1].ToString(), emp);
            string fecha = Convert.ToString(CalFecha.SelectedDate);
            fecha = fecha + Convert.ToString(DdlHora.SelectedItem);
            sol.Fecha = Convert.ToDateTime(fecha);
            sol.Solicita = (Solicitante)Session["Solicitante"];
            sol.UnTramite = tra;
            sol.Estado = "Alta";
            new ServicioClient().AltaSolicitud(sol, (Solicitante)Session["Solicitante"]);
            LblError.Text = "Alta con Exito";
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
}