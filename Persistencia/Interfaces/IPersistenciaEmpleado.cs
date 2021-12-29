using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public interface IPersistenciaEmpleado
    {
        Empleado Logueo(string contra, int cedula);
        void Alta(Empleado oEmp, Empleado EmpleadoActual);
        void Baja(Empleado oEmp, Empleado EmpleadoActual);
        void Modificar(Empleado oEmp, Empleado EmpleadoActual);
        Empleado Buscar(int cedula, Empleado EmpleadoActual);
    }
}
