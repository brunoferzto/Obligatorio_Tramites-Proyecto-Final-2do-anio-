using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Data.SqlClient;

namespace Persistencia
{
    internal class Conexion
    {
        private static string _cnn = @"Data Source=DESKTOP-9RS7HI4\EQUIPO; Initial Catalog = Tramites; Integrated Security = true;";
        internal static string Cnn
        {
            get { return _cnn; }
        }
        internal static string ConexionUsuario(Usuario usu)
        {
            if (usu != null)
                return @"Data Source=DESKTOP-9RS7HI4\EQUIPO;  Initial Catalog = Tramites; User ID=" + usu.Cedula.ToString() + "; Password='" + usu.Contraseña + "'";
            else
                return @"Data Source=DESKTOP-9RS7HI4\EQUIPO;  Initial Catalog = Tramites; Integrated Security = true;";
        }
    }

}
