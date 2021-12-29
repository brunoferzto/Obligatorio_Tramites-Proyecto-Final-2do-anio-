using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaTiposdeTramite : IPersistenciaTiposdeTramite
    {
        private static PersistenciaTiposdeTramite _instancia = null;
        private PersistenciaTiposdeTramite() { }
        public static PersistenciaTiposdeTramite GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaTiposdeTramite();
            return _instancia;
        }

        public void Alta(TiposdeTramite oTram, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _comando = new SqlCommand("AgregarTipoDeTramite", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oTram.Codigo);
            _comando.Parameters.AddWithValue("@nom", oTram.Nombre);
            _comando.Parameters.AddWithValue("@des", oTram.Descripcion);
            _comando.Parameters.AddWithValue("@pre", oTram.Precio);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);
            SqlTransaction Transaccion = null;
            try
            {
                _cnn.Open();
                Transaccion = _cnn.BeginTransaction();
                _comando.Transaction = Transaccion;
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Tipo de Tramite ya Existe - No se Agrego");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se agrego el Tipo de Tramite por error de la transaccion");
                foreach (Documentacion doc in oTram.DocumentoLista)
                {
                    AgregarDocumentacion(oTram.Codigo, doc.Codigo, Transaccion);
                }
                Transaccion.Commit();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback(); 
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

        }

        public void Baja(TiposdeTramite oTram, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _comando = new SqlCommand("EliminarTipoDeTramite", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oTram.Codigo);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El Tipo de Tramite no Existe - No se Elimino");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se elimino el Tipo de Tramite por error de la transaccion");
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

       public TiposdeTramite Buscar(string codigo, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            TiposdeTramite _unTipo = null;
            List<Documentacion> doc = new List<Documentacion>();
            SqlCommand _comando = new SqlCommand("BuscarTipoDeTramite", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", codigo);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    doc = BuscarDocumentacion(codigo, EmpleadoActual);
                    _unTipo = new TiposdeTramite(doc, codigo, (string)_lector["nombre"], (int)_lector["precio"], (string)_lector["descripcion"]);
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
            return _unTipo;
        }
        public TiposdeTramite BuscarActivo(string codigo, Usuario usuActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            TiposdeTramite _unTipo = null;
            List<Documentacion> doc = new List<Documentacion>();
            SqlCommand _comando = new SqlCommand("BuscarTipoDeTramiteActivo", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", codigo);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    doc = BuscarDocumentacion(codigo, usuActual); 
                    _unTipo = new TiposdeTramite(doc, codigo, (string)_lector["nombre"], (int)_lector["precio"], (string)_lector["descripcion"]);
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
            return _unTipo;
        }
        public List<TiposdeTramite> Listar(Usuario usuActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            TiposdeTramite _unTramite = null;
            List<TiposdeTramite> _lista = new List<TiposdeTramite>();
            SqlCommand _comando = new SqlCommand("ListarTiposDeTramites", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;

            try
            {
                 
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read()) 
                    {
                        _unTramite = new TiposdeTramite(BuscarDocumentacion((string)_lector["codigo"], usuActual), (string)_lector["codigo"], (string)_lector["nombre"], (int)_lector["precio"], (string)_lector["descripcion"]);
                        _lista.Add(_unTramite);
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
        public void Modificar(TiposdeTramite oTram, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("ModificarTipoDeTramite", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@cod", oTram.Codigo);
            _comando.Parameters.AddWithValue("@nom", oTram.Nombre);
            _comando.Parameters.AddWithValue("@des", oTram.Descripcion);
            _comando.Parameters.AddWithValue("@pre", oTram.Precio);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);
            SqlTransaction Transaccion = null;
            try
            {
                _cnn.Open();
                Transaccion = _cnn.BeginTransaction();
                EliminarDocumentacion(oTram.Codigo, Transaccion);
                _comando.Transaction = Transaccion;
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD: No existe el Tipo de Tramite - No se modifica");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se modifico el Tipo de Tramite por error de la transaccion");
                foreach (Documentacion doc in oTram.DocumentoLista)
                {
                    AgregarDocumentacion(oTram.Codigo, doc.Codigo, Transaccion);
                }
                Transaccion.Commit();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }
        }
        internal void AgregarDocumentacion(string tramitecod, int doccodigo, SqlTransaction Transaccion)
        {
            SqlCommand oComando = new SqlCommand("AltaContiene", Transaccion.Connection);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@cod", tramitecod);
            oComando.Parameters.AddWithValue("@doccod", doccodigo);
            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);
            int oAfectados = 0;
            try
            {

                oComando.Transaction = Transaccion;
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("BD:El Tipo de Tramite no existe - No se agrego");
                if (oAfectados == -2)
                    throw new Exception("BD:La Documentacion no existe - No se agrego");
                if (oAfectados == -3)
                    throw new Exception("BD:La Documentacion ya se encuentra agregada - No se agrego");
                if (oAfectados == -3)
                    throw new Exception("BD:Fallo la transaccion - No se pudo agregar el Documento");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal void EliminarDocumentacion(string tramitecod, SqlTransaction Transaccion)
        {
            SqlCommand oComando = new SqlCommand("BajaContiene", Transaccion.Connection);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@cod", tramitecod);
            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);
            int oAfectados = 0;
            try
            {
                oComando.Transaction = Transaccion;
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("BD:Fallo la transaccion - No se pudo eliminar la Documentacion");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal List<Documentacion> BuscarDocumentacion(string codigo, Usuario usuActual)
        { 
            //  creo q no. x eso esta aca el buscar documentacion (CREO) 
            int doc;
            List<Documentacion> documentacion = new List<Documentacion>();
            SqlDataReader oReader;
            SqlConnection oConexion = new SqlConnection(Conexion.ConexionUsuario(usuActual));
            SqlCommand oComando = new SqlCommand("BuscarContiene", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@cod", codigo);
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.HasRows)
                {
                    while (oReader.Read())
                    {
                        doc = (int)oReader["doccodigo"];
                        documentacion.Add(FabricaPersistencia.GetPersistenciaDocumentacion().BuscarActiva(doc, usuActual));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
            return documentacion;
        }
    }
}
