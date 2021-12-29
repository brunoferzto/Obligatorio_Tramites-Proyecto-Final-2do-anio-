using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaDocumentacion GetPersistenciaDocumentacion()
        {
            return (PersistenciaDocumentacion.GetInstancia());
        }

        public static IPersistenciaEmpleado GetPersistenciaEmpleado()
        {
            return (PersistenciaEmpleado.GetInstancia());
        }

        public static IPersistenciaHorasExtras GetPersistenciaHorasExtras()
        {
            return (PersistenciaHorasExtras.GetInstancia());
        }

        public static IPersistenciaSolicitante GetPersistenciaSolicitante()
        {
            return (PersistenciaSolicitante.GetInstancia());
        }

        public static IPersistenciaSolicitud GetPersistenciaSolicitud()
        {
            return (PersistenciaSolicitud.GetInstancia());
        }

        public static IPersistenciaTiposdeTramite GetPersistenciaTiposdeTramite()
        {
            return (PersistenciaTiposdeTramite.GetInstancia());
        }

        

        //gg izi
    }
}
