using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaDocumentacion : IPersistenciaDocumentacion
    {
        private static PersistenciaDocumentacion _instancia = null;
        private PersistenciaDocumentacion() { }
        public static PersistenciaDocumentacion GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaDocumentacion();
            return _instancia;
        }

        public void Alta(Documentacion oDoc, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("AgregarDocumentacion", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oDoc.Codigo);
            _comando.Parameters.AddWithValue("@nom", oDoc.Nombre);
            _comando.Parameters.AddWithValue("@lug", oDoc.LugarObtencion);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:La Documentacion ya Existe - No se Agrego");
                else if ((int)_retorno.Value == -2)
                {
                    throw new Exception("BD:No se agrego la Documentacion por error de la transaccion");
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

        }

        public void Baja(Documentacion oDoc, Empleado EmpleadoActual)
        {

            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));

            SqlCommand _comando = new SqlCommand("EliminarDocumentacion", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oDoc.Codigo);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:La Documentacion no Existe - No se Elimino");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se elimino la Documentacion por error de la transaccion");



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

        internal Documentacion Buscar(int unCod, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            Documentacion _unaDocumentacion = null;

            SqlCommand _comando = new SqlCommand("BuscarDocumentacion", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", unCod);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unaDocumentacion = new Documentacion(unCod, (string)_lector["nombre"], (string)_lector["lugarobtencion"]);
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
            return _unaDocumentacion;
        } 
        public Documentacion BuscarActiva(int unCod, Usuario usuActual) 
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(usuActual));
            Documentacion _unaDocumentacion = null;

            SqlCommand _comando = new SqlCommand("BuscarDocumentacionActiva", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", unCod);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unaDocumentacion = new Documentacion(unCod, (string)_lector["nombre"], (string)_lector["lugarobtencion"]);
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
            return _unaDocumentacion;
        }

        public void Modificar(Documentacion oDoc, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("ModificarDocumentacion", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oDoc.Codigo); //1
            _comando.Parameters.AddWithValue("@lug", oDoc.LugarObtencion);
            _comando.Parameters.AddWithValue("@nom", oDoc.Nombre); //two

            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:La Documentacion no Existe - No se Modifico");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se modifico la Documentacion por error de la transaccion");
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
        public List<Documentacion> ListarDocumentacion(Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            Documentacion _unaDocumentacion = null;
            List<Documentacion> _lista = new List<Documentacion>();

            SqlCommand _comando = new SqlCommand("ListarDocumentacion", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _unaDocumentacion = new Documentacion((int)_lector["doccodigo"], (string)_lector["nombre"], (string)_lector["lugarobtencion"]);
                        _lista.Add(_unaDocumentacion);
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
