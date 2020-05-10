using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            var db = new stjupDataContext();

            var login = from log in db.users select log;


            foreach (user u in login)
            {

                if ((txtusername.Value).Equals(u.Username) && (txtpass.Value).Equals(u.Passwor))
                {

                    Response.Redirect("product.aspx");

                }
                else
                {
                    report.InnerHtml = "Username or/and Password invalid.";

                }
            }
        }
    }
    
}