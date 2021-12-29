using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaHorasExtras : IPersistenciaHorasExtras
    {
        private static PersistenciaHorasExtras _instancia = null;
        private PersistenciaHorasExtras() { }
        public static PersistenciaHorasExtras GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaHorasExtras();
            return _instancia;
        }

        public void Alta(HorasExtras unaHora, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("AgregarHorasExtra", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@fec", unaHora.Fecha);
            _comando.Parameters.AddWithValue("@ced", unaHora.Empleado.Cedula);
            _comando.Parameters.AddWithValue("@min", unaHora.Minutos);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Empleado no Existe - No se Agrego");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se agregon las Horas Extras por error de la transaccion");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
        }
    }
}
