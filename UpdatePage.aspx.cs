using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace loginandregister
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        void clearText()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Yes.Checked = false;
            No.Checked = false;
        }
        string strCon = WebConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strAp;

            if (Yes.Checked == true)
            {
                strAp = "yes";
            }
            else
            {
                strAp = "no";
            }

            
            try
            {
                SqlConnection objCon = new SqlConnection(strCon);
                string strQuery = "update user_det2 set fname=@fname, lname=@lname, mobile=@mobile, address = @address, pass = @pass, aproval = @approval where fname = @fname";
                objCon.Open();
                SqlCommand objCmd = new SqlCommand(strQuery, objCon);
                objCmd.Parameters.AddWithValue("@fname", TextBox1.Text);
                objCmd.Parameters.AddWithValue("@lname", TextBox2.Text);
                objCmd.Parameters.AddWithValue("@mobile", TextBox3.Text);
                objCmd.Parameters.AddWithValue("@address", TextBox4.Text);
                objCmd.Parameters.AddWithValue("@pass", TextBox5.Text);
                objCmd.Parameters.AddWithValue("@approval", strAp);
                int i = objCmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Label7.Text = "Updated Successfully!";
                    clearText();
                }
                objCon.Close();
            }
            catch
            {
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            try 
            {
                SqlConnection objConn = new SqlConnection(strCon);
                string strQuery = "select * from user_det2 where fname=@fname";
                objConn.Open();
                string approval;
                SqlCommand objCmd = new SqlCommand(strQuery, objConn);
                objCmd.Parameters.AddWithValue("@fname", TextBox6.Text);
                SqlDataReader objRead = objCmd.ExecuteReader();
                if (objRead.Read())
                {
                    TextBox1.Text = objRead.GetString(0);
                    TextBox2.Text = objRead.GetString(1);
                    TextBox3.Text = objRead.GetString(2);
                    TextBox4.Text = objRead.GetString(3);
                    TextBox5.Text = objRead.GetString(4);
                    approval = objRead.GetString(5);
                    Label7.Text = approval;

                     /*if (approval.Equals("no"))
                    {
                       No.Checked = true;
                    }
                    else
                    {
                        Yes.Checked = true;
                    } */
                } 
                else
                {
                    Label7.Text = "Invalid Name";
                }
                objConn.Close();
            }
            
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                    SqlConnection objConn = new SqlConnection(strCon);
                    string strQuery = "delete from user_det2 where fname=@fname";
                    objConn.Open();
                    SqlCommand objCmd = new SqlCommand(strQuery, objConn);
                    objCmd.Parameters.AddWithValue("@fname", TextBox6.Text);
                    int i = objCmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Label7.Text = "Deleted Succesfully";
                    clearText();
                    
                    }
            }

            catch
            {

            }
        }
    }
}