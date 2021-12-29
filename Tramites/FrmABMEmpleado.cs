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
    public partial class FrmABMEmpleado : Form
    {
        private Empleado emp;
        private Usuario usu = null;
        public FrmABMEmpleado(Empleado emplea2)
        {
            InitializeComponent();
            emp = emplea2;
        }
        private void BotonesporDefecto()
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;

            TxtCedula.Text = "";
            TxtContra.Text = "";
            TxtNomCompleto.Text = "";

            DtpHoraInicio.Format = DateTimePickerFormat.Time;
            DtpHoraInicio.ShowUpDown = true;

            DtpHoraFin.Format = DateTimePickerFormat.Time;
            DtpHoraFin.ShowUpDown = true;


            TxtCedula.Focus();

            usu = null;


        }
        private void ActualizoBotones()
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;

            TxtContra.Text = usu.Contraseña;
            TxtNomCompleto.Text = usu.Nombre;

            DtpHoraInicio.Format = DateTimePickerFormat.Time;
            DtpHoraInicio.ShowUpDown = true;
            DtpHoraInicio.Value = Convert.ToDateTime(((Empleado)usu).HoraInicio);
            
            DtpHoraFin.Format = DateTimePickerFormat.Time;
            DtpHoraFin.ShowUpDown = true;
            DtpHoraFin.Value = Convert.ToDateTime(((Empleado)usu).HoraFin);
        }
        private void ActivoAgregar()
        {
            btnagregar.Enabled = true;
            btneliminar.Enabled = false;
            btnmodificar.Enabled = false;

            TxtContra.Text = "";
            TxtNomCompleto.Text = "";
            

            usu = null;
        }
        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnvercontra_Click(object sender, EventArgs e)
        {
            if (TxtContra.UseSystemPasswordChar == false)
                TxtContra.UseSystemPasswordChar = true;
            else
                TxtContra.UseSystemPasswordChar = false;
        }


        private void TxtCedula_Validating(object sender, CancelEventArgs e)
        {
            usu = null;
            try 
            {
                lblerror.Text = "";
                usu = new ServicioClient().BuscarUsuario(Convert.ToInt32(TxtCedula.Text), emp);
                if (usu == null)
                    this.ActivoAgregar();
                else
                {
                    if (usu is Empleado)
                        this.ActualizoBotones();
                    else
                    {
                        lblerror.Text = "La Cédula pertenece a un Usuario Solicitante";
                        BotonesporDefecto();
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            usu = new Usuario();
            try
            {
                lblerror.Text = "";
                usu = new Empleado();


                    ((Empleado)usu).HoraFin = DtpHoraFin.Value.ToShortTimeString();
                    ((Empleado)usu).HoraInicio = DtpHoraInicio.Value.ToShortTimeString();
                     usu.Cedula = Convert.ToInt32(TxtCedula.Text);
                    usu.Contraseña = TxtContra.Text.Trim();
                    usu.Nombre = TxtNomCompleto.Text.Trim();
                    ServicioClient SEmpleado = new ServicioClient();
                    SEmpleado.AltaUsuario(usu, emp);
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
                usu = new ServicioClient().BuscarUsuario(Convert.ToInt32(TxtCedula.Text), emp);
                if (usu == null)
                    throw new Exception("No se encontro el Empleado para Eliminarlo");

                if (emp.Cedula != usu.Cedula)
                {
                    ServicioClient SEmpleado = new ServicioClient();
                    SEmpleado.BajaUsuario(usu, emp);
                    lblerror.Text = "Baja con Exito";
                }
                else
                    lblerror.Text = "No se puede eliminar el Empleado Logueado";

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
                if (emp.Cedula == usu.Cedula)
                {
                    usu.Contraseña = TxtContra.Text.Trim();
                }
                lblerror.Text = "";

                ((Empleado)usu).HoraFin = DtpHoraFin.Value.ToShortTimeString();
                ((Empleado)usu).HoraInicio = DtpHoraInicio.Value.ToShortTimeString();
                usu.Cedula = Convert.ToInt32(TxtCedula.Text);
                usu.Nombre = TxtNomCompleto.Text.Trim();
                ServicioClient SEmpleado = new ServicioClient();
                SEmpleado.ModificarUsuario(usu, emp);
                lblerror.Text = "Modificacion con Exito";

                emp.Contraseña = TxtContra.Text.Trim(); // listo

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

        private void FrmABMEmpleado_Load(object sender, EventArgs e)
        {
            BotonesporDefecto();
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
