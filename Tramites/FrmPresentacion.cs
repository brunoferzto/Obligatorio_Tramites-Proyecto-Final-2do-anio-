using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Tramites
{
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
          
                //deshabilito
                Cronometro.Enabled = false;
                //oculto 
                this.Hide();
                //muestro logueo
                FrmLogueo _unForm = new FrmLogueo();
                _unForm.ShowDialog();
                //cierro el formulario actual
                this.Close();    
        }

        private void lblnombres_Click(object sender, EventArgs e)
        {

        }
    }
}
