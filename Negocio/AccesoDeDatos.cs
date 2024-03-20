using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDeDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private SqlDataReader _lector;
        public AccesoDeDatos()
        {
            _conexion = new SqlConnection("SERVER=.\\SQLEXPRESS01; DATABASE=CATALOGO_WEB_DB; INTEGRATED SECURITY=YES");
            _comando = new SqlCommand();
        }
        public SqlDataReader Lector
        {
            get { return _lector; }
        }
        public void SetearConsulta(string consulta)
        {
            _comando.CommandType = System.Data.CommandType.Text;
            _comando.CommandText = consulta;
        }
        public void SetearComando(string parametro, object valor)
        {
            _comando.Parameters.AddWithValue(parametro, valor);
        }
        public void EjecutarConsulta()
        {
            _comando.Connection = _conexion;
            _conexion.Open();
            _lector = _comando.ExecuteReader();
        }
        public void EjecutarAccion()
        {
            _comando.Connection = _conexion;
            _conexion.Open();
            _comando.ExecuteNonQuery();
        }
        public void CerrarConexion()
        {
            if(_lector != null)
                _lector.Close();
            if(_conexion != null)
                _conexion.Close();
        }
    }
}
