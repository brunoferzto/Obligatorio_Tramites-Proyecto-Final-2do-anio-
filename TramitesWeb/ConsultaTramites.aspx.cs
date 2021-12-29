using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Servicio;
using System.Xml.Linq;

public partial class ConsultaTramites : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Empleado emp = null;
            if (!IsPostBack)
            {
                Session["Solicitante"] = null;
                for (int i = 0; i <= 10; i++)
                {
                    ddlAño.Items.Add((DateTime.Now.Year - i).ToString());
                }
                string listatramites = new ServicioClient().ListarTiposdeTramite(emp).ToString();
                XElement documento = XElement.Parse(listatramites);
                var resultado = (from Nodo in documento.Elements("Tramite")
                                 select
                                 new
                                 {
                                     Tramite = Nodo.Element("Nombre").Value,
                                     Codigo = Nodo.Element("Codigo").Value
                                 }).ToList();
                RtTipoTramites.DataSource = resultado;
                RtTipoTramites.DataBind();

                Session["Tramites"] = documento;
            }
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnFiltrarPrecio_Click(object sender, EventArgs e)
    {
        try
        {
            XElement documento = (XElement)Session["Tramites"];
            var resultado = (from Nodo in documento.Elements("Tramite")
                             where Convert.ToInt32(txtPrecio.Text) > Convert.ToInt32(Nodo.Element("Precio").Value)
                             select
                             new
                             {
                                 Tramite = Nodo.Element("Nombre").Value,
                                 Codigo = Nodo.Element("Codigo").Value
                             }).ToList();
            RtTipoTramites.DataSource = resultado;
            RtTipoTramites.DataBind();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }

    protected void BtnFiltrarAnio_Click(object sender, EventArgs e)
    {
        try
        {
            XElement documento = (XElement)Session["Tramites"];
            var resultado = (from Nodo in documento.Elements("Tramite")
                             where Convert.ToString(Nodo.Element("Codigo")).Substring(0, 4) == Convert.ToString(ddlAño.Text.Substring(0, 4))
                             select
                             new
                             {
                                 Tramite = Nodo.Element("Nombre").Value,
                                 Codigo = Nodo.Element("Codigo").Value
                             }).ToList();
            RtTipoTramites.DataSource = resultado;
            RtTipoTramites.DataBind();
        }
        catch (Exception ex)
        {
            LblError.Text = ex.Message;
        }
    }
    protected void RtTipoTramites_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Seleccionar")
        {
            try
            {
                XElement documento = (XElement)Session["Tramites"];

                var resultado = (from Nodo in documento.Elements("Tramite")
                                 where (string)Nodo.Element("Codigo") == ((TextBox)(e.Item.Controls[3])).Text
                                 select Nodo);

                string res = "<Raiz>";
                foreach (var Nodo in resultado)
                {
                    res += Nodo.ToString();
                }
                res += "</Raiz>";

                XmlTramite.DocumentContent = res;
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }
}