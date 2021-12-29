using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaUsuario
    {
        Usuario BuscarUsuario(int cedula, Empleado EmpleadoActual);
        void AltaUsuario(Usuario oUsuario, Usuario UsuarioActual);
        void ModificarUsuario(Usuario oUsuario, Empleado EmpleadoActual);
        void BajaUsuario(Usuario oUsuario, Empleado EmpleadoActual);
        Usuario LogueoUsuario(string contra, int cedula);
    }
}
