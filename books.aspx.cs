using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String dis = " ";
            dis += "<div>";
            dis += "<h2>";
            dis += "book collection 1 : R99.99";
            dis += "</h2>";
            dis += "<br />";
            dis += "<img  height=250 width=250 src='images/books/1.jpeg'/>";
            dis += "<br />";       
            dis += "</div>";

            dis += "<br />";

            dis += "<div>";
            dis += " ";
            dis += "<h2>";
            dis += "book collection 2 : R199.99";
            dis += "</h2>";
            dis += "<br />";
            dis += "<img  height=250 width=250 src='images/books/2.jpeg'/>";                   
            dis += "</div>";
            display.InnerHtml = dis;
        }
    }
}