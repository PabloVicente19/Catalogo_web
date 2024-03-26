using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class UsuarioNegocio
    {
        AccesoDeDatos _datos;
        public void AgregarUsuario(Usuario usuario)
        {
            _datos = new AccesoDeDatos();
            try
            {
                _datos.SetearConsulta("");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _datos.CerrarConexion();
            }
        }
    }
}
