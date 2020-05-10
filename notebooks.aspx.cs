using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class notebooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String dis = " ";
            dis += "<div>";
            dis += "<h2>";
            dis += "colored cover notebooks : R100.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/13.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "Notebook Collection : R150.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/14.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "A5 Notebook : R40.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/15.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "Notebook set : R120.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/16.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "2 Quire : R10.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/17.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "Pink Notebook : R13.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/18.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += " 72 pages : R7.99";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/19.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += " Black book : R10.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/20.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "Color notebooks  : R15.00 each";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/21.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "A4 Colored notebooks : R12.00 each";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/22.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "A4 notebooks : R14.00 each";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/23.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "White notebook : R15.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/24.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "notebook : R4.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/25.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += " 2x notebook : R20.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/notebooks/26.jpeg'/>";

            display.InnerHtml = dis;
        }
    }
}