using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaDocumentacion
    {
        Documentacion BuscarDocumentacionActiva(int codigo, Empleado EmpleadoActual);
        void AltaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        void ModificarDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        void BajaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual);
        List<Documentacion> ListarDocumentacion(Empleado EmpleadoActual);
    }
}
