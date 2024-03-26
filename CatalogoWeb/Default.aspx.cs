using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        ArticuloNegocio articuloNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                articuloNegocio = new ArticuloNegocio();
                List<Articulo> productos = articuloNegocio.Listar();
                repeater.DataSource = productos;
                repeater.DataBind();
            }
        }

        protected void btnVerProducto_Click(object sender, EventArgs e)
        {
            string idProducto = ((Button)sender).CommandArgument;
            Response.Redirect("DetalleDeProducto.aspx?id=" + idProducto, false);
        }
        public void FiltrarProducto(string criterio)
        {
            switch (criterio)
            {
                case "Menor Precio":
                    AplicarFiltro(criterio);
                    break;
                case "Mayor Precio":
                    AplicarFiltro(criterio);
                    break;
                default:
                    return;
            }
        }
        public List<Articulo> AplicarFiltro(string criterio)
        {
            articuloNegocio = new ArticuloNegocio();
            List<Articulo> filtrados = articuloNegocio.Listar();

            if(criterio == "Menor Precio")
            {

            for (int i = 0; i < filtrados.Count; i++)
            {
                for (int j = 1; j < filtrados.Count; j++)
                {
                    if (filtrados[i].Precio > filtrados[j].Precio)
                    {
                        Articulo temp = filtrados[i];
                        filtrados[i] = filtrados[j];
                        filtrados[j] = temp;
                    }
                }
            }
            }
            return filtrados;

        }
        
    }
}