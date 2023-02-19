using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginandregister
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strAp;

            if (yes.Checked == true)
            {
                strAp = "yes";
            }
            else
            {
               strAp = "";
            }

            void clearText()
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                yes.Checked = false;
                RadioButton2.Checked = false;
            }
            string strConn = WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            SqlConnection objCon = new SqlConnection(strConn);
            string strQuery = "insert into user_det2 values(@fname, @lname, @mobile, @address, @pass, @approve)";

            try
            {
                objCon.Open();
                SqlCommand objCmd = new SqlCommand(strQuery, objCon);
                objCmd.Parameters.AddWithValue("@fname", TextBox1.Text);
                objCmd.Parameters.AddWithValue("@lname", TextBox2.Text);
                objCmd.Parameters.AddWithValue("@mobile", TextBox3.Text);
                objCmd.Parameters.AddWithValue("@address", TextBox4.Text);
                objCmd.Parameters.AddWithValue("@pass", TextBox5.Text);
                objCmd.Parameters.AddWithValue("@approve", strAp);
                int intFlag = objCmd.ExecuteNonQuery();
                if (intFlag > 0)
                {
                    Label7.Text = "yey inserted";
                    clearText();
                }

            }
            catch { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Response.Redirect("LoginPage.aspx");
        }
    }
}