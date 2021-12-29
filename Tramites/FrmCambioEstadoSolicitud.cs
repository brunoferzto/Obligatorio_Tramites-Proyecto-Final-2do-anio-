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
    public partial class FrmCambioEstadoSolicitud : Form
    {
        List<Solicitud> lista;
        Empleado empLogueado;
        public FrmCambioEstadoSolicitud(Empleado empL)
        {
            InitializeComponent();
            empLogueado = empL;
        }

        private void CargarDatos()
        {
            try
            {
                lista = new ServicioClient().ListarSolicitudesAlta(empLogueado).ToList();

                var resultado = (from unR in lista
                                 select new
                                 {
                                     Numero = unR.Numero,
                                     Fecha = unR.Fecha.ToShortDateString(),
                                     Solicitante = unR.Solicita.Nombre + " - " + unR.Solicita.Cedula,
                                     Tramite = unR.UnTramite.Nombre + " - " + unR.UnTramite.Codigo,

                                 }).ToList();


                dgvSolicitudes.DataSource = resultado;

            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void FrmCambioEstadoSolicitud_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string nombrecolumna = dgvSolicitudes.Columns[e.ColumnIndex].Name;

                if (nombrecolumna == "Ejecutada" || nombrecolumna == "Anulada")
                {
                    Solicitud sol = lista[e.RowIndex];
                    sol.Estado = nombrecolumna;

                    new ServicioClient().CambiarEstado(sol, empLogueado);
                    lista.Remove(sol);
                    CargarDatos();
                }

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
    }
}
