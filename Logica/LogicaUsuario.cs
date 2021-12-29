using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaUsuario: ILogicaUsuario
    {
        private static LogicaUsuario _instancia = null;
        private LogicaUsuario() { }
        public static LogicaUsuario GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaUsuario();

            return _instancia;
        }
        public Usuario BuscarUsuario(int cedula, Empleado EmpleadoActual)
        {
            Usuario usu = null;
            usu = FabricaPersistencia.GetPersistenciaEmpleado().Buscar(cedula, EmpleadoActual);
            if (usu == null)
            {
                usu = FabricaPersistencia.GetPersistenciaSolicitante().Buscar(cedula, EmpleadoActual);
            }
            return usu;
        }
        public void AltaUsuario (Usuario oUsuario, Usuario UsuarioActual)
        {
            if (oUsuario is Empleado)
                FabricaPersistencia.GetPersistenciaEmpleado().Alta((Empleado)oUsuario, (Empleado)UsuarioActual);
            else
                FabricaPersistencia.GetPersistenciaSolicitante().Alta((Solicitante)oUsuario);
        }
        public void ModificarUsuario (Usuario oUsuario, Empleado EmpleadoActual)
        {
            if (oUsuario is Empleado)
                FabricaPersistencia.GetPersistenciaEmpleado().Modificar((Empleado)oUsuario, EmpleadoActual);
            else
                throw new ArgumentException("No se realizo la baja porque el Usuario no era Empleado");
        }
        public void BajaUsuario(Usuario oUsuario, Empleado EmpleadoActual)
        {
            if (oUsuario is Empleado)
                FabricaPersistencia.GetPersistenciaEmpleado().Baja((Empleado)oUsuario, EmpleadoActual);
            else
                throw new ArgumentException("No se realizo la baja porque el Usuario no era Empleado");

        }
        public Usuario LogueoUsuario(string contra, int cedula)
        {
            Usuario usu = null;
            usu = FabricaPersistencia.GetPersistenciaEmpleado().Logueo(contra, cedula);
            if (usu == null)
                usu = FabricaPersistencia.GetPersistenciaSolicitante().Logueo(contra, cedula);
            return usu;
        }
    }
}
