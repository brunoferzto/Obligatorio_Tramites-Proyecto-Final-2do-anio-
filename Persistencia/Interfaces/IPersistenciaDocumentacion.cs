using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaDocumentacion
    {
        void Alta(Documentacion oDoc, Empleado EmpleadoActual);
        void Baja(Documentacion oDoc, Empleado EmpleadoActual);
        void Modificar(Documentacion oDoc, Empleado EmpleadoActual);
        Documentacion BuscarActiva(int unCod, Usuario usuActual);
        List<Documentacion> ListarDocumentacion(Empleado EmpleadoActual);
    }
}
