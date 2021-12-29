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
using System.IO; 

namespace Tramites
{
    public partial class FrmPrincipal : Form
    {
        private Empleado empLogueado;

        public FrmPrincipal(Empleado empL)
        {
            InitializeComponent();
            empLogueado = empL; 
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMEmpleado _unForm = new FrmABMEmpleado(empLogueado);
            _unForm.ShowDialog();
        }

        private void dFGHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioEstadoSolicitud _unForm = new FrmCambioEstadoSolicitud(empLogueado);
            _unForm.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout _unform = new FrmAbout();
            _unform.ShowDialog();
        }

        private void listadoDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoSolicitudes _unForm = new FrmListadoSolicitudes(empLogueado);
            _unForm.ShowDialog();
        }

        private void aBMDocumentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMDocumentacion _unForm = new FrmABMDocumentacion(empLogueado);
            _unForm.ShowDialog();
        }

        private void aBMTiposDeTramiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMTipodeTramite _unForm = new FrmABMTipodeTramite(empLogueado);
            _unForm.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string a = Application.StartupPath;
            File.Delete(a + "_Documento.xml");
        }
    }
}
