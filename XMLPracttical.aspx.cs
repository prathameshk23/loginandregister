using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace loginandregister
{
    public partial class XMLPracttical : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void clearText()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings xmlSet = new XmlWriterSettings();
            xmlSet.Indent = true;
            xmlSet.NewLineChars = ("\n");


            XmlWriter xmlWrite = XmlWriter.Create(Server.MapPath("student.xml"),xmlSet);

            xmlWrite.WriteStartDocument();

            xmlWrite.WriteStartElement("StudentData");
            xmlWrite.WriteStartElement("student");
            xmlWrite.WriteElementString("FirstName", TextBox1.Text);
            xmlWrite.WriteElementString("LastName", TextBox3.Text);
            xmlWrite.WriteElementString("MobileNumber", TextBox2.Text);

            xmlWrite.WriteEndElement();
            xmlWrite.WriteEndDocument();

            xmlWrite.Flush();
            xmlWrite.Close();
            clearText();

            Label1.Text = "File Created";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath("student.xml")))
            {
                XmlTextReader textRead = new XmlTextReader(Server.MapPath("student.xml"));
                textRead.ReadToFollowing("student");

                do
                {
                    textRead.ReadToFollowing("FirstName");
                    Label2.Text = textRead.ReadElementContentAsString();

                    textRead.ReadToFollowing("LastName");
                    Label3.Text = textRead.ReadElementContentAsString();

                    textRead.ReadToFollowing("MobileNumber");
                    Label4.Text = textRead.ReadElementContentAsString();
                } while (textRead.ReadToFollowing("student"));
                textRead.Close();
            }
            else
            {
                Label5.Text = "File Not Found";
            }
        }
    }
}