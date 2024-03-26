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
        public List<Articulo> AplicarFiltro(string criterio)
        {
            articuloNegocio = new ArticuloNegocio();
            List<Articulo> filtrados = articuloNegocio.Listar();

            if (criterio == "Menor Precio")
            {
                filtrados.Sort((a, b) => a.Precio.CompareTo(b.Precio));
            }
            else if (criterio == "Mayor Precio")
            {
                filtrados.Sort((a, b) => b.Precio.CompareTo(a.Precio));
            }
            return filtrados;
        }
        protected void DdlFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = DdlFiltro.SelectedItem.ToString();
            if (criterio != null)
            {
                repeater.DataSource = null;
                repeater.DataSource = AplicarFiltro(criterio);
                repeater.DataBind();
            }
        }
    }
}