using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
   
    public partial class Login : System.Web.UI.Page
    {
        public string Email { get; set; }
        public string Contraseña { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnInicarSesion_Click(object sender, EventArgs e)
        {
                string email = txtEmail.Text;
                string contraseña = txtContraseña.Text;
        }
    }
}