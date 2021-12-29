using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaHorasExtras: ILogicaHorasExtras
    {
        private static LogicaHorasExtras _instancia = null;
        private LogicaHorasExtras() { }
        public static LogicaHorasExtras GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaHorasExtras();

            return _instancia;
        }
        public void AltaHorasExtra (HorasExtras oHorasExtra, Empleado EmpleadoActual)
        {
            FabricaPersistencia.GetPersistenciaHorasExtras().Alta(oHorasExtra, EmpleadoActual);
        }
    }
}
