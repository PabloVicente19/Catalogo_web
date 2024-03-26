using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}