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
    public partial class FrmListadoSolicitudes : Form
    {
        List<Solicitud> lista = new List<Solicitud>();
        Empleado empLogueado;
        public FrmListadoSolicitudes(Empleado empLog)
        {
            InitializeComponent();
            empLogueado = empLog;
        }

        private void PorDefecto()
        {
            try
            {
                var resultado = (from unR in lista
                                 where unR.Fecha.Year == DateTime.Now.Year
                                 select new
                                 {
                                     Estado = unR.Estado,
                                     Fecha = unR.Fecha,
                                     Numero = unR.Numero,
                                     Solicitante = unR.Solicita.Cedula,
                                     Tramite = unR.UnTramite.Codigo

                                 }).ToList();

                dgvlistado.DataSource = resultado;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        private void btnTipodeT_Click(object sender, EventArgs e)
        {
            try
            {
                PorDefecto();
                var resultado = (from unR in lista
                                 group unR by unR.UnTramite.Codigo
                                 into unRR
                                 orderby unRR.First().UnTramite.Nombre
                                 select new
                                 {
                                     Tramite = unRR.First().UnTramite.Nombre + " - " +
                                                                unRR.First().UnTramite.Codigo,
                                     Cantidad = unRR.Count()


                                 }).ToList();

                dgvlistado.DataSource = resultado;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnmesual_Click(object sender, EventArgs e)
        {
            try
            {
                PorDefecto();
                var resultado = (from unR in lista
                                 group unR by unR.Fecha.Month
                                 into unRR
                                 where unRR.First().Fecha.Year == DateTime.Now.Year
                                 select new
                                 {
                                     Mes =  unRR.First().Fecha.Month,
                                     Cantidad = unRR.Count()

                                 }).ToList();

                dgvlistado.DataSource = resultado;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btndocumentacion_Click(object sender, EventArgs e)
        {
            //try
            //{//  despliega para cada tipo de documentación, la cantidad de solicitudes que la exigen. 

                //  solicitud tiene tipo de tramite
                //tipo de tramite tiene lista de documentacion
                //Es que no es con join... doble recorrida (una de solicitudes en la lista de solicitudes, y la segunda de documentos dentro de una solicitud

            //    PorDefecto();
            //    int i = 0;

            //    // no t estoy ecuchando mucho

            //    var resultado = (from regSol in lista
            //                     from regDoc in lista.First().UnTramite.DocumentoLista                               
            //                     where regDoc.Codigo == regSol.UnTramite.DocumentoLista.First().Codigo 
            //                     select new
            //                     {
            //                         Documentacion = regDoc.Nombre, 
            //                         Cantidad =

            //                     }).ToList();

            //    dgvlistado.DataSource = resultado;
            //}
            //catch (Exception ex)
            //{
            //    lblerror.Text = ex.Message;
            //}
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string selec = DtpFecha.Value.ToShortDateString();

                PorDefecto();
                var resultado = (from unR in lista
                                 where unR.Fecha.ToShortDateString() == selec
                                 orderby unR.Fecha.Hour
                                 select new
                                 {
                                     Estado = unR.Estado,
                                     Fecha = unR.Fecha,
                                     Numero = unR.Numero,
                                     Solicitante = unR.Solicita.Cedula,
                                     Tramite = unR.UnTramite.Codigo

                                 }).ToList();

                dgvlistado.DataSource = resultado;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            PorDefecto();
        }

        private void FrmListadoSolicitudes_Load(object sender, EventArgs e)
        {
            try
            {
                lista = new ServicioClient().ListarSolicitudes(empLogueado).ToList();
                PorDefecto();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }
}
