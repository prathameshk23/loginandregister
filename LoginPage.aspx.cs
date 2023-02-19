using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace loginandregister
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strCon = WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            SqlConnection objCon =  new SqlConnection(strCon);
            objCon.Open();
            string strQuery = "select * from loginDetails where user_name = @user and pass_word = @pass";
            SqlCommand objCmd = new SqlCommand(strQuery, objCon);
            objCmd.Parameters.AddWithValue("@user", TextBox1.Text);
            objCmd.Parameters.AddWithValue("@pass", TextBox2.Text);

            try
            {
                
                SqlDataAdapter objAd = new SqlDataAdapter(objCmd);
                DataTable dt = new DataTable();
                objAd.Fill(dt);
                int i = objCmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0 )
                {
                    Session["User"] = TextBox1.Text;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label3.Text = "error";
                }
            }
            catch { }

        }
    }
}