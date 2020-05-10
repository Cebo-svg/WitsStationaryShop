using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnbooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("books.aspx");
        }

        protected void btnpens_Click(object sender, EventArgs e)
        {
            Response.Redirect("pens.aspx");
        }

        protected void btnbags_Click(object sender, EventArgs e)
        {
            Response.Redirect("bags.aspx");
        }

        protected void btnnotebooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("notebooks.aspx");
        }



    }
}