using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class bags : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String dis = " ";

            dis += "<div>";
            dis += "<h2>";
            dis += "Stripped Bag : R299.99";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/bags/12.jpeg'/>";        
            dis += "</div>";

            display.InnerHtml = dis;
         
        }
    }
}