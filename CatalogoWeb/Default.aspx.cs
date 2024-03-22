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
                repeater.DataSource = articuloNegocio.Listar();
                repeater.DataBind();
            }
        }

        protected void btnVerProducto_Click(object sender, EventArgs e)
        {
            string idProducto = ((Button)sender).CommandArgument;
            Response.Redirect("DetalleDeProducto.aspx?id=" + idProducto, false);
        }
    }
}