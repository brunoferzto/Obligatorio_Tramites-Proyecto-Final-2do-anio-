using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaSolicitud
    {
        void AltaSolicitud(Solicitud oSolicitud, Solicitante SolicitanteActual);
        void CambiarEstado(Solicitud oSolicitud, Empleado EmpleadoActual);
        List<Solicitud> ListarSolicitudes(Empleado EmpleadoActual);
        List<Solicitud> ListarSolicitudesAlta(Empleado EmpleadoActual);
    }
}
