using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaSolicitante
    {
        void Alta(Solicitante oSol);
        Solicitante Logueo(string contra, int cedula);
        Solicitante Buscar(int cedula, Empleado EmpleadoActual);
    }
}
