using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaSolicitud: ILogicaSolicitud
    {
        private static LogicaSolicitud _instancia = null;
        private LogicaSolicitud() { }
        public static LogicaSolicitud GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaSolicitud();

            return _instancia;
        }
        public void AltaSolicitud(Solicitud oSolicitud, Solicitante SolicitanteActual)
        {
            FabricaPersistencia.GetPersistenciaSolicitud().Alta(oSolicitud, SolicitanteActual);
        }
        public void CambiarEstado(Solicitud oSolicitud, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaSolicitud().CambiarEstado(oSolicitud, EmpleadoActual);
        }
        public List<Solicitud> ListarSolicitudes(Empleado EmpleadoActual)
        {
            return (FabricaPersistencia.GetPersistenciaSolicitud().Listar(EmpleadoActual));
        }
        public List<Solicitud> ListarSolicitudesAlta(Empleado EmpleadoActual)
        {
            return (FabricaPersistencia.GetPersistenciaSolicitud().ListadoAltas(EmpleadoActual));
        }
    }
}
