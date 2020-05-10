using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stjup
{
    public partial class pens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String dis = " ";
            dis += "<div>";
            dis += "<h2>";
            dis += "Clutch set : R100.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/3.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";       
            dis += "Clutch Pencil : R25.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/4.jpeg'/>";


            dis += "<br />";

            dis += "<h2>";
            dis += "HB Pencil set : R40.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/5.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "Colouring Pencils : R22.00";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/6.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "HB Pencil : R2.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/7.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += "B Pencil : R4.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/8.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += " yellow HB Pencil : R2.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/9.jpeg'/>";

            dis += "<br />";

            dis += "<h2>";
            dis += " Blue HB Pencil : R2.50";
            dis += "</h2>";
            dis += "<img  height=250 width=250 src='images/pens/11.jpeg'/>";
            dis += "</div>";
          
            display.InnerHtml = dis;
        }
    }
}