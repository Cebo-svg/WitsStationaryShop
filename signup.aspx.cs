using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreate_Click(object sender, EventArgs e)
        {

            var db = new stjupDataContext();
            dynamic ifm = from st in db.users
                          select st;
            bool isReg = false;
            foreach (user u in ifm)
            {
                if ((txtusername.Value).Equals(u.Username)  && (txtpass.Value).Equals(u.Passwor))
                {

                    isReg = true;
                    report.InnerHtml = "<br/>" + "<br/>" + "<br/>" + "user already exist";
                }

            }

            if (isReg == false)
            {

                var regUser = new user
                {

                    Username = txtusername.Value,
                    Passwor = txtpass.Value,
                };
                db.users.InsertOnSubmit(regUser);

                try
                {
                    db.SubmitChanges();
                    Response.Redirect("login.aspx");
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    report.InnerHtml = "Something went Wrong";

                }


            }

     	}
		
			
        
    }
}