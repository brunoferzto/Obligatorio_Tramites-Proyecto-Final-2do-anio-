using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Logica;
using EntidadesCompartidas;
using System.Configuration;
using System.IO;
using System.Xml.Linq;

namespace ServicioWin
{
    partial class ServicioHoras : ServiceBase
    {
        Empleado EmpNull = null;
        Empleado unemp;
        public ServicioHoras()
        {
            InitializeComponent();
        }


        protected override void OnStart(string[] args)
        {
            //Inicio del servicio
            Mensaje.WriteEntry("Inicia el servicio - ServicioHoras");

            //iniciamos timer
            Cronometro.Enabled = true;
            Cronometro.Start();
        }

        protected override void OnStop()
        {
            // Se detiene el servicio
            Mensaje.WriteEntry("Se detiene el servicio - ServicioHoras");

            //Frenamos la ejecucion
            Cronometro.Enabled = false;
            Cronometro.Stop();

        }

        protected override void OnPause()
        {
            // Pausa del servicio

            Mensaje.WriteEntry("Se pausa el servicio - ServicioHoras");

            //Frenamos la ejecucion
            Cronometro.Enabled = false;
            Cronometro.Stop();
        }

        protected override void OnContinue()
        {
            //Continua el servicio
            Mensaje.WriteEntry("Se continua ejecutando el servicio - ServicioHoras");

            //iniciamos timer
            Cronometro.Enabled = true;
            Cronometro.Stop();
        }



        private void FswXml_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {

                if (e.Name.ToLowerInvariant().Contains("_Documento"))
                {
                    //cargo documento
                    XDocument _doc = XDocument.Load("~/LoginXML/_Documento.xml"); //REVISAR RUTA DEL XML
                    int ced = Convert.ToInt32(_doc.Element("Cedula").ToString());
                    unemp = (Empleado)FabricaLogica.GetLogicaUsuario().BuscarUsuario(ced, EmpNull);


                    Mensaje.WriteEntry("El Empleado "+ unemp.Nombre +" inicio sesion");
                }
                
            }
            catch (Exception x)
            {
                Mensaje.WriteEntry(x.Message + " - archivo " + e.Name, EventLogEntryType.Error);
            }
        }

        private void FswXml_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {

                if (e.Name.ToLowerInvariant().Contains("_Documento"))
                {

                    Mensaje.WriteEntry("El Empleado " + unemp.Nombre + " cerro sesion");
                    unemp = null;
                }
               
            }
            catch (Exception x)
            {
                Mensaje.WriteEntry(x.Message + " - archivo " + e.Name, EventLogEntryType.Error);
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            try
            {
                XDocument _doc = XDocument.Load("~/LoginXML/_Documento.xml"); //REVISAR RUTA DEL XML

                //int ced = Convert.ToInt32(_doc.Element("Cedula").ToString());
                //unemp = (Empleado)FabricaLogica.GetLogicaUsuario().BuscarUsuario(ced, EmpNull);

                //verificar si esta en horas extras
                DateTime xhorafin = Convert.ToDateTime(_doc.Element("HorarioFinal").ToString());


                if (xhorafin.Hour <= DateTime.Now.Hour)
                {
                    int minutos= ((DateTime.Now.Hour - xhorafin.Hour) * 60) + (DateTime.Now.Minute - xhorafin.Minute);
                    HorasExtras horaextra = new HorasExtras(DateTime.Now.Date, minutos, unemp);
                    FabricaLogica.GetLogicaHorasExtras().AltaHorasExtra(horaextra, EmpNull);
                }

            }
            catch (Exception)
            {

               //nada jeje
            }
        }
    }
}
