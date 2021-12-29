using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tramites.Servicio;

namespace Tramites
{
    public partial class FrmABMDocumentacion : Form
    {
        private Empleado emp;
        private Documentacion documentacion = null;
        public FrmABMDocumentacion(Empleado Empleado)
        {
            InitializeComponent();
            emp = Empleado;
        }
        private void BotonesporDefecto()
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;

            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtlugobtencion.Text = "";

            documentacion = null;
            txtcodigo.Focus();
        }
        private void ActualizoBotones()
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;

            txtnombre.Text = documentacion.Nombre.ToString();
            txtlugobtencion.Text = documentacion.LugarObtencion.ToString();
        }
        private void ActivoAgregar()
        {
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;

            txtnombre.Text = "";
            txtlugobtencion.Text = "";

            documentacion = null;
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmABMDocumentacion_Load(object sender, EventArgs e)
        {

        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            documentacion = null;
            try
            {
                lblerror.Text = "";
                documentacion = new ServicioClient().BuscarDocumentacionActiva(Convert.ToInt32(txtcodigo.Text), emp);
                if (documentacion == null)
                    this.ActivoAgregar();
                else
                    this.ActualizoBotones();
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Documentacion doc;
            try
            {
                doc = new Documentacion();
                doc.Codigo = Convert.ToInt32(txtcodigo.Text);
                doc.Nombre = txtnombre.Text.Trim();
                doc.LugarObtencion = txtlugobtencion.Text.Trim();
                ServicioClient SDocumentacion = new ServicioClient();
                SDocumentacion.AltaDocumentacion(doc, emp);
                lblerror.Text = "Alta con Exito";
                this.BotonesporDefecto();
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                documentacion = new ServicioClient().BuscarDocumentacionActiva(Convert.ToInt32(txtcodigo.Text), emp);
                if (documentacion == null)
                    throw new Exception("No se encontro la Documentacion para Eliminarla");
                else
                {
                    ServicioClient SDocumentacion = new ServicioClient();
                    SDocumentacion.BajaDocumentacion(documentacion, emp);
                    lblerror.Text = "Baja con Exito";
                }
                this.BotonesporDefecto();
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                documentacion.Codigo = Convert.ToInt32(txtcodigo.Text);
                documentacion.Nombre = txtnombre.Text.Trim();
                documentacion.LugarObtencion = txtlugobtencion.Text.Trim();
                ServicioClient SDocumentacion = new ServicioClient();
                SDocumentacion.ModificarDocumentacion(documentacion, emp);
                lblerror.Text = "Modificacion con Exito";
                this.BotonesporDefecto();
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.BotonesporDefecto();
        }
    }
}
