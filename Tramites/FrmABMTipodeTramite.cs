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
    public partial class FrmABMTipodeTramite : Form
    {
        TiposdeTramite tdtBuscado;
        Empleado empLogueado;
        List<Documentacion> docSistemaList;
        List<Documentacion> docTramiteList;
        public FrmABMTipodeTramite(Empleado emp)
        {
            InitializeComponent();
            empLogueado = emp;
        }

        protected void ActivoxDefecto()
        {
            try
            {

                TxtCodigo.Text = "";
                TxtCodigo.Enabled = true;
                TxtNombre.ReadOnly = true;
                TxtNombre.Text = "";
                TxtDescripcion.Enabled = false;
                TxtDescripcion.Text = "";
                TxtPrecio.Enabled = false;
                TxtPrecio.Text = "";
                documentossistema.Enabled = false;
                LbDocumentacion.Enabled = false;

                btnagregar.Enabled = false;
                btneliminar.Enabled = false;
                btnmodificar.Enabled = false;

                tdtBuscado = null;
                docTramiteList = new List<Documentacion>();
                lblerror.Text = "";
                ActualizarDocumentacion();

                TxtCodigo.Focus();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }


        }
        protected void ActivoAgregar()
        {
            TxtCodigo.Enabled = false;
            TxtNombre.ReadOnly = false;
            TxtDescripcion.Enabled = true;
            TxtPrecio.Enabled = true;
            documentossistema.Enabled = true;
            LbDocumentacion.Enabled = true;

            btnagregar.Enabled = true;
        }

        protected void ActivoActualizacion()
        {
            try
            {
                TxtCodigo.Enabled = false;
                TxtNombre.ReadOnly = false;
                TxtDescripcion.Enabled = true;
                TxtPrecio.Enabled = true;
                documentossistema.Enabled = true;
                LbDocumentacion.Enabled = true;
                btneliminar.Enabled = true;
                btnmodificar.Enabled = true;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        protected void ActualizarDocumentacion()
        {
            try
            {

                LbDocumentacion.DataSource = null;
                LbDocumentacion.Items.Clear();
                LbDocumentacion.DataSource = docTramiteList;
                LbDocumentacion.DisplayMember = "Nombre";
                lblerror.Text = "";
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(TxtCodigo.Text.Substring(0, 4)) == Convert.ToInt32(DateTime.Now.Year))
                {

                    TiposdeTramite nuevoTramite = new TiposdeTramite();
                    nuevoTramite.Nombre = TxtNombre.Text.Trim();
                    nuevoTramite.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                    nuevoTramite.Descripcion = TxtDescripcion.Text.Trim();
                    nuevoTramite.Codigo = TxtCodigo.Text.Trim();
                    nuevoTramite.DocumentoLista = docTramiteList.ToArray();

                    new ServicioClient().AltaTiposdeTramite(nuevoTramite, empLogueado);

                    ActivoxDefecto();
                    lblerror.Text = "Registro Correcto";
                }
                else
                    lblerror.Text = "Los 4 digitos iniciales deben corresponder al año actual ";
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }


        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (TxtCodigo.Text != "")
                {
                    tdtBuscado = new ServicioClient().BuscarTiposdeTramiteActivo(TxtCodigo.Text.Trim(), empLogueado);

                    if (tdtBuscado != null)
                    {
                        TxtCodigo.Text = tdtBuscado.Codigo;
                        TxtNombre.Text = tdtBuscado.Nombre;
                        TxtDescripcion.Text = tdtBuscado.Descripcion;
                        TxtPrecio.Text = tdtBuscado.Precio.ToString();
                        docTramiteList = tdtBuscado.DocumentoLista.ToList();
                        LbDocumentacion.DataSource = docTramiteList;
                        ActivoActualizacion();
                    }
                    else
                        ActivoAgregar();
                }
                else
                {
                    TxtCodigo.Focus();
                    lblerror.Text = "Ingrese un Código Válido";
                }
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void FrmABMTipodeTramite_Load(object sender, EventArgs e)
        {
            try
            {
                docSistemaList = new ServicioClient().ListarDocumentacion(empLogueado).ToList();
                documentossistema.DataSource = docSistemaList;
                documentossistema.DisplayMember = "Nombre";
                ActivoxDefecto();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ActivoxDefecto();
        }

        private void BtnEliminarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (LbDocumentacion.SelectedIndex != -1)
                {
                    docTramiteList.Remove(docTramiteList[LbDocumentacion.SelectedIndex]);
                    ActualizarDocumentacion();
                    lblerror.Text = "";
                }
                else
                    lblerror.Text = "Selecciona un elemento para quitarlo";
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void documentossistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (tdtBuscado != null || TxtCodigo.Text != "")
                {
                    Documentacion niuDoc = docSistemaList[documentossistema.SelectedIndex];

                    bool ver = false;

                    foreach (Documentacion unDoc in docTramiteList) // el contains no sirve para los ya buscados
                    {
                        if (niuDoc.Codigo == unDoc.Codigo)
                        {
                            ver = true;

                        }
                    } // fin foreach 
                    if (ver == false)
                    {
                        docTramiteList.Add(niuDoc);
                        ActualizarDocumentacion();
                    }
                }


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


                new ServicioClient().BajaTiposdeTramite(tdtBuscado, empLogueado);
                ActivoxDefecto();
                lblerror.Text = "Eliminación Correcta";


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

                tdtBuscado.Nombre = TxtNombre.Text.Trim();
                tdtBuscado.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                tdtBuscado.Descripcion = TxtDescripcion.Text.Trim();
                tdtBuscado.DocumentoLista = docTramiteList.ToArray();

                new ServicioClient().ModificarTiposdeTramite(tdtBuscado, empLogueado);

                ActivoxDefecto();
                lblerror.Text = "Modificación Correcta";


            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void TxtPrecio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToInt32(TxtPrecio.Text.Trim());
                lblerror.Text = "";
            }
            catch
            {
                lblerror.Text = "Ingresar un valor númerico entero";
                TxtPrecio.Text = "";
                TxtPrecio.Focus();
            }


        }
    }
}
