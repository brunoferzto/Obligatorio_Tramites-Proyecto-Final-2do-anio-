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
using System.Xml;
using System.IO;



namespace Tramites
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();
        }
       
        

        private void FrmLogueo_Load(object sender, EventArgs e)
        {

        }

        private void CrearXML(Empleado empl)
        {
            try
            {
                XmlDocument _Documento = new XmlDocument();
                _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
                XmlNode _raiz = _Documento.DocumentElement;

                XmlElement Cedula = _Documento.CreateElement("Cedula");
                Cedula.InnerText = empl.Cedula.ToString();

                XmlElement Usuario = _Documento.CreateElement("Usuario");
                Usuario.InnerText = empl.Nombre;

                XmlElement HorarioI = _Documento.CreateElement("HorarioInicial");
                HorarioI.InnerText = empl.HoraInicio;

                XmlElement HorarioF = _Documento.CreateElement("HorarioFinal");
                HorarioF.InnerText = empl.HoraFin;

                XmlElement Nodo = _Documento.CreateElement("UsuarioLogueado");
                Nodo.AppendChild(Cedula);
                Nodo.AppendChild(Usuario);
                Nodo.AppendChild(HorarioI);
                Nodo.AppendChild(HorarioF);

                _raiz.AppendChild(Nodo);

                string a = Application.StartupPath;
                _Documento.Save(a + "_Documento.xml");
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message; 
            }

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usu = new ServicioClient().LogueoUsuario(txtusuario.Text.Trim(), Convert.ToInt32(txtcontra.Text.Trim()));

                if (usu != null && usu is Empleado)
                {
                    Empleado empLog = new Empleado();
                    empLog.Nombre = usu.Nombre;
                    empLog.Cedula = usu.Cedula;
                    empLog.Contraseña = usu.Contraseña;
                    empLog.HoraInicio = DateTime.Now.ToString();
                    empLog.HoraFin = DateTime.Now.ToString();
                    this.Hide();
                    
                    CrearXML(empLog);

                    FrmPrincipal _unForm = new FrmPrincipal(empLog);
                    _unForm.ShowDialog();
                    this.Close();
                }
                else
                    lblerror.Text = "Error, datos inválidos";
            }
            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }
    }
}
