using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FileUploadBtn_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExtension = Path.GetExtension(FileUpload1.FileName);

                if(fileExtension.ToLower() != ".doc" && fileExtension.ToLower() != ".pdf" && fileExtension.ToLower() != ".png")
                {
                    lblMessage.Text = "Only .doc, .pdf, png are allowed";
                    lblMessage.ForeColor = Color.Red;
                }else
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;

                    if(fileSize > 2097152)
                    {
                        lblMessage.Text = "Maximum file size (2mb) exceeded";
                        lblMessage.ForeColor = Color.Red;
                    }
                    FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                    lblMessage.Text = FileUpload1.FileName + "Added";
                    lblMessage.ForeColor = Color.Green;
                }


            }
            else
            {
                lblMessage.Text = "Please select a file ";
                lblMessage.ForeColor = Color.Red;
            }


        }
    }
}