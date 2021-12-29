using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaEmpleado:IPersistenciaEmpleado
    {
        private static PersistenciaEmpleado _instancia = null;
        private PersistenciaEmpleado() { }
        public static PersistenciaEmpleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaEmpleado();
            return _instancia;
        }

        public void Alta(Empleado oEmp, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("AgregarEmpleado", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", oEmp.Cedula);
            _comando.Parameters.AddWithValue("@con", oEmp.Contraseña);
            _comando.Parameters.AddWithValue("@nom", oEmp.Nombre);
            _comando.Parameters.AddWithValue("@ini", oEmp.HoraInicio);
            _comando.Parameters.AddWithValue("@fin", oEmp.HoraFin);
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

        public void Baja(Empleado oEmp, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
          
            SqlCommand _comando = new SqlCommand("EliminarEmpleado", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", oEmp.Cedula);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Empleado no Existe - No se Elimino");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se Elimino el Empleado por error de la transaccion");


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

        public Empleado Buscar(int cedula, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            Empleado _unEmpleado = null;

            SqlCommand _comando = new SqlCommand("BuscarEmpleado", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", cedula);

            try
            { 
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    _unEmpleado = new Empleado((string)_lector["nombre"], (string)_lector["contraseña"], cedula, (string)_lector["horainicio"].ToString(), (string)_lector["horafin"].ToString());
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
            return _unEmpleado;

        }

        public Empleado Logueo(string contra, int cedula)
        {

            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Empleado _unEmpleado = null;

            SqlCommand _comando = new SqlCommand("LogueoEmpleado", _cnn);
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
                    _unEmpleado = new Empleado((string)_lector["nombre"], (string)_lector["contraseña"], cedula, (string)_lector["horainicio"].ToString(), (string)_lector["horafin"].ToString());
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
            return _unEmpleado;


        }

        public void Modificar(Empleado oEmp, Empleado EmpleadoActual)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.ConexionUsuario(EmpleadoActual));
            SqlCommand _comando = new SqlCommand("ModificarEmpleado", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ced", oEmp.Cedula);
            _comando.Parameters.AddWithValue("@con", oEmp.Contraseña);
            _comando.Parameters.AddWithValue("@nom", oEmp.Nombre);
            _comando.Parameters.AddWithValue("@ini", oEmp.HoraInicio);
            _comando.Parameters.AddWithValue("@fin", oEmp.HoraFin);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("BD:El Empleado no Existe - No se Modifico");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("BD:No se Modifico el Empleado por error de la transaccion");
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
