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
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strConn = WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            SqlConnection objCon = new SqlConnection(strConn);
            string strQuery = "insert into loginDetails values(@user, @pass)";

            try
            {
                objCon.Open();
                SqlCommand objCmd = new SqlCommand(strQuery, objCon);
                objCmd.Parameters.AddWithValue("@user", TextBox1.Text);
                objCmd.Parameters.AddWithValue("@pass", TextBox2.Text);
                int intFlag = objCmd.ExecuteNonQuery();
                if (intFlag > 0)
                {
                    Label2.Text = "yey inserted";
                }

            }
            catch { }
        }
    }
}