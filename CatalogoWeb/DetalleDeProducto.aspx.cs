using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace CatalogoWeb
{
    public partial class DetalleDeProducto : System.Web.UI.Page
    {
        ArticuloNegocio _negocio;
        public List<Articulo> Producto { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _negocio = new ArticuloNegocio();
                if (Request.QueryString["Id"] != null)
                {
                    int idProducto = Convert.ToInt32(Request.QueryString["id"].ToString());
                    Producto = _negocio.Listar(idProducto);
                    repetidor.DataSource = Producto;
                    repetidor.DataBind();
                }
            }
        }
        protected void BtnVolverAlHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }
    }
}