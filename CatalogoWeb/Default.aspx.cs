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
            articuloNegocio = new ArticuloNegocio();
            repeater.DataSource = articuloNegocio.Listar();
            repeater.DataBind();
        }
    }
}