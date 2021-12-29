using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaSolicitud
    {
        void Alta(Solicitud oSol, Solicitante SolicitanteActual);
        void CambiarEstado(Solicitud oSol, Empleado EmpleadoActual);
        List<Solicitud> Listar(Empleado EmpleadoActual);
        List<Solicitud> ListadoAltas(Empleado EmpleadoActual);
    }
}
