using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StemPractice
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Jahnavi button created");
        }

        protected void Button2_Click(System.Object sender, System.EventArgs e)
        {
            Response.Write("Ayesha button created");
        }

        protected void btnAnusha_Click(System.Object sender, System.EventArgs e)
        {
            Response.Write("Anusha button created");
        }
    }
}