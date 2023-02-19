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
    public partial class CriPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddmatch_Click(object sender, EventArgs e)
        {
            string conn = WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            SqlConnection objc = new SqlConnection(conn);

            string qry = "insert into MatchDetails values(@id,@sc,@wick,@ovr)";

            try
            {
                objc.Open();
                SqlCommand cmd = new SqlCommand(qry, objc);

                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@sc", txtscore.Text);
                cmd.Parameters.AddWithValue("@wick", txtwick.Text);
                cmd.Parameters.AddWithValue("@ovr", txtovers.Text);

                int flag = cmd.ExecuteNonQuery();
                if(flag > 0)
                {
                    txtid.Text = "";
                    txtscore.Text = "";
                    txtwick.Text = "";
                    txtovers.Text = "";

                    lblextra.Text = "Record is Inserted!";
                }

            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                objc.Close();
            }
        }
    }
}