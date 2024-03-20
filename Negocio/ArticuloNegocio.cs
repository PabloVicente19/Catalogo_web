using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        AccesoDeDatos _datos;
        public List<Articulo> Listar()
        {
            _datos = new AccesoDeDatos();
            List<Articulo> listado = new List<Articulo>();
            try
            {
                _datos.SetearConsulta("select Articulos.Id Id,Codigo,Nombre,Articulos.Descripcion Descripcion,MARCAS.Descripcion Marca,CATEGORIAS.Descripcion Categoria,ImagenUrl, Precio from ARTICULOS, MARCAS,CATEGORIAS where MARCAS.Id = ARTICULOS.IdMarca and CATEGORIAS.Id = ARTICULOS.IdCategoria");
                _datos.EjecutarConsulta();
                while (_datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)_datos.Lector["Id"];
                    aux.Codigo = (string)_datos.Lector["Codigo"];
                    aux.Nombre = (string)_datos.Lector["Nombre"];
                    aux.Descripcion = (string)_datos.Lector["Descripcion"];
                    aux.IdMarca = new Marca();
                    aux.IdMarca.Descripcion = (string)_datos.Lector["Marca"];
                    aux.IdCategoria = new Categoria();
                    aux.IdCategoria.Descripcion = (string)_datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)_datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)_datos.Lector["Precio"];

                    listado.Add(aux);
                }
                return listado;
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
