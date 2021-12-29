using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaDocumentacion: ILogicaDocumentacion
    {
        private static LogicaDocumentacion _instancia = null;
        private LogicaDocumentacion() { }
        public static LogicaDocumentacion GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaDocumentacion();

            return _instancia;
        }
        public Documentacion BuscarDocumentacionActiva(int codigo, Empleado EmpleadoActual)
        {
            return (FabricaPersistencia.GetPersistenciaDocumentacion().BuscarActiva(codigo, EmpleadoActual));
        }
        public void AltaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaDocumentacion().Alta(oDocumentacion, EmpleadoActual);
        }
        public void ModificarDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaDocumentacion().Modificar(oDocumentacion, EmpleadoActual);
        }
        public void BajaDocumentacion(Documentacion oDocumentacion, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaDocumentacion().Baja(oDocumentacion, EmpleadoActual);
        }
        public List<Documentacion> ListarDocumentacion(Empleado EmpleadoActual)
        {
            return (FabricaPersistencia.GetPersistenciaDocumentacion().ListarDocumentacion(EmpleadoActual));
        }
    }
}
