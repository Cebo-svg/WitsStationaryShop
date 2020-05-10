using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace stjup
{
    public partial class Register_User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConsString"].ConnectionString;
        }
        private void ExecuteInsert(string FirstName, string LastName, string email, string Password, string telephone, string gender, string age, string address)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            string sql = "INSERT INTO [dbo.Register](First Name, Last Name, Paasword, Gender, Age, Address) VALUES "
                    + " (@First Name, @Last Name,@E-Mail, @Paasword, @Gender, @Age, @Address)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[7];
                // param[0] = new SqlParameter("@id", SqlDbType.Int,20);
                param[0] = new SqlParameter("@First Name", System.Data.SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@Last Name", System.Data.SqlDbType.VarChar, 50);
                param[2] = new SqlParameter("@E_Mail", System.Data.SqlDbType.VarChar, 100);
                param[3] = new SqlParameter("@Telephone", System.Data.SqlDbType.VarChar, 11);
                param[4] = new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50);
                param[5] = new SqlParameter("@Gender", System.Data.SqlDbType.VarChar, 10);
                param[6] = new SqlParameter("@Address", System.Data.SqlDbType.VarChar, 100);

                param[0].Value = FirstName;
                param[1].Value = LastName;
                param[2].Value = Password;
                param[3].Value = email;
                param[4].Value = telephone;
                param[5].Value = gender;
                param[6].Value = address;

                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch 
            {
                
                
            }

            finally
            {
                conn.Close();
                Response.Redirect("Product.aspx");


            }
        }

        protected void Btt1_Click(object sender, EventArgs e)
        {

                if (TextPassword.Text == TxtRePassword.Text)
                {
                    ExecuteInsert(TxtName.Text, TxtUserName.Text, TxtEMAIL.Text, TextPassword.Text, TxtTelephone.Text, DropDownList1.SelectedItem.Text, TxtAge.Text, TxtAddress.Text);
                    Response.Write("Record Was Successfully added");
                    ClearControls(Page);
                    

                 
                   

                }
            
            else
            {
                Response.Write("Password Did Not Match");
                TextPassword.Focus();
            }

        }
        public static void ClearControls(Control Parent) 
        {
            if(Parent is TextBox) 
            {
                (Parent as TextBox).Text = string.Empty;
            }
            else 
            {
                foreach (Control c in Parent.Controls)
                    ClearControls(c);
            }
            
        }

       

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }

}


   
