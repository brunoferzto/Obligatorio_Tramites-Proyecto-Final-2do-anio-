using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaSolicitante : IPersistenciaSolicitante
    {
        private static PersistenciaSolicitante _instancia = null;
        private PersistenciaSolicitante() { }
        public static PersistenciaSolicitante GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaSolicitante();
            return _instancia;
        }

        public void Alta(Solicitante oSol)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _comando = new SqlCommand("AgregarSolicitante", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", oSol.Cedula);
            _comando.Parameters.AddWithValue("@con", oSol.Contraseña);
            _comando.Parameters.AddWithValue("@nom", oSol.Nombre);
            _comando.Parameters.AddWithValue("@tel", oSol.Telefono);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Usuario ya Existe - No se Agrego");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se agrego el Empleado por error de la transaccion");
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

        public Solicitante Buscar(int cedula, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            Solicitante _unSolicitante = null;

            SqlCommand _comando = new SqlCommand("BuscarSolicitante", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", cedula);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unSolicitante = new Solicitante((string)_lector["nombre"], (string)_lector["contraseña"], (int)_lector["cedula"], (string)_lector["telefono"]);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _unSolicitante;
        }

        public Solicitante Logueo(string contra, int cedula)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Solicitante _unSolicitante = null;

            SqlCommand _comando = new SqlCommand("LogueoSolicitante", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", cedula);
            _comando.Parameters.AddWithValue("@con", contra);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unSolicitante = new Solicitante((string)_lector["nombre"], (string)_lector["contraseña"],(int)_lector["cedula"], (string)_lector["telefono"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _unSolicitante;
        }
    }
}
