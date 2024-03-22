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
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)_datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)_datos.Lector["Categoria"];
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
        public List<Articulo> Listar(int idProducto)
        {
            _datos = new AccesoDeDatos();
            List<Articulo> producto = new List<Articulo>();
            try
            {
                _datos.SetearConsulta("SELECT A.Id Id,Nombre,A.Descripcion Descripcion,MAR.Descripcion as Marca,CAT.Descripcion as Categoria,ImagenUrl,Precio FROM ARTICULOS AS A JOIN MARCAS AS MAR ON A.IdMarca = MAR.Id JOIN CATEGORIAS AS CAT ON A.IdCategoria = CAT.Id WHERE A.Id = @idProducto");
                _datos.SetearParametro("@idProducto", idProducto);
                _datos.EjecutarConsulta();
                while (_datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)_datos.Lector["Id"];
                    articulo.Nombre = (string)_datos.Lector["Nombre"];
                    articulo.Descripcion = (string)_datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)_datos.Lector["Marca"];
                    articulo.Categoria =  new Categoria();
                    articulo.Categoria.Descripcion = (string)_datos.Lector["Categoria"];
                    articulo.ImagenUrl = (string)_datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)_datos.Lector["Precio"];
                    producto.Add(articulo);
                } 
                return producto;
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
