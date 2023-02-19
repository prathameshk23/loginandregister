using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace loginandregister
{
    public partial class XMLPRac2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void clear_text()
        {
            TextBox1.Text ="";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings xmlset = new XmlWriterSettings();
            xmlset.Indent = true;
            xmlset.NewLineChars = ("\n");

            XmlWriter xmlwrite = XmlWriter.Create(Server.MapPath("student2.xml"), xmlset);

            xmlwrite.WriteStartDocument();

            xmlwrite.WriteStartElement("StudentDetails");
            xmlwrite.WriteStartElement("student2");

            xmlwrite.WriteElementString("FullName", TextBox1.Text);
            xmlwrite.WriteElementString("Email", TextBox2.Text);
            xmlwrite.WriteElementString("ContactNo", TextBox3.Text);

            xmlwrite.WriteEndElement();
            xmlwrite.WriteEndDocument();

            xmlwrite.Flush();
            xmlwrite.Close();

            clear_text();
            Label1.Text = "Recors inserted in File";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath("student2.xml")))
            {
                XmlTextReader textRead = new XmlTextReader(Server.MapPath("student2.xml"));
                textRead.ReadToFollowing("student2");

                do
                {
                    textRead.ReadToFollowing("FullName");
                    Label2.Text = textRead.ReadElementContentAsString();


                    textRead.ReadToFollowing("Email");
                    Label3.Text = textRead.ReadElementContentAsString();


                    textRead.ReadToFollowing("ContactNo");
                    Label4.Text = textRead.ReadElementContentAsString();



                } while (textRead.ReadToFollowing("student2"));
                textRead.Close();

            }
        }
    }
}