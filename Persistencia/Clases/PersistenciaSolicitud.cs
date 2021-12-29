using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaSolicitud : IPersistenciaSolicitud
    {
        private static PersistenciaSolicitud _instancia = null;
        private PersistenciaSolicitud() { }
        public static PersistenciaSolicitud GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaSolicitud();
            return _instancia;
        }

        public void Alta(Solicitud oSol, Solicitante SolicitanteActual)
        {

            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(SolicitanteActual));
            SqlCommand _comando = new SqlCommand("AgregarSolicitud", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@num", oSol.Numero);
            _comando.Parameters.AddWithValue("@fec", oSol.Fecha);
            _comando.Parameters.AddWithValue("@ced", oSol.Solicita.Cedula);
            _comando.Parameters.AddWithValue("@cod", oSol.UnTramite.Codigo);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Solicitante no Existe - No se Agrego");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:El Tipo de Tramite no Existe - No se Agrego");
                else if ((int)_retorno.Value == -3)
                    throw new Exception("BD:No se agrego la Solicitud por error de la transaccion");
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

        public void CambiarEstado(Solicitud oSol, Empleado EmpleadoActual)
        {

            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("CambiarEstadoSolicitud", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@num", oSol.Numero);
            _comando.Parameters.AddWithValue("@est", oSol.Estado);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:La Solicitud no Existe - No se Modifico");
                else if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El estado no se encuentra entre los posibles - No se Modifico");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se agrego la Solicitud por error de la transaccion");
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

        public List<Solicitud> ListadoAltas(Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Solicitud _unaSolicitud = null;
            List<Solicitud> _lista = new List<Solicitud>();

            SqlCommand _comando = new SqlCommand("ListarSolicitudesAlta", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unaSolicitud = new Solicitud((DateTime)_lector["fechayhora"], (int)_lector["numero"], (string)_lector["estado"],
                            FabricaPersistencia.GetPersistenciaSolicitante().Buscar((int)_lector["cedula"], EmpleadoActual),
                            FabricaPersistencia.GetPersistenciaTiposdeTramite().Buscar((string)_lector["codigo"], EmpleadoActual));
                        _lista.Add(_unaSolicitud);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }

        public List<Solicitud> Listar(Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Solicitud _unaSolicitud = null;
            List<Solicitud> _lista = new List<Solicitud>();

            SqlCommand _comando = new SqlCommand("ListarSolicitudes", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unaSolicitud = new Solicitud((DateTime)_lector["fechayhora"], (int)_lector["numero"], (string)_lector["estado"],
                            FabricaPersistencia.GetPersistenciaSolicitante().Buscar((int)_lector["cedula"], EmpleadoActual),
                            FabricaPersistencia.GetPersistenciaTiposdeTramite().Buscar((string)_lector["codigo"], EmpleadoActual));
                        _lista.Add(_unaSolicitud);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }
    }
}
