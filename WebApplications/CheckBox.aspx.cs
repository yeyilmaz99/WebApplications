using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class CheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbChoices = new StringBuilder();
            string str = "";
            if (CheckBox1.Checked)
            {
                sbChoices.Append(CheckBox1.Text);
                str = CheckBox1.Text;
            }
            if(CheckBox2.Checked)
            {
                sbChoices.Append(CheckBox2.Text);
                str = CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                sbChoices.Append(CheckBox3.Text);
                str = CheckBox3.Text;
            }
            Response.Write(sbChoices.ToString());
                Response.Write(str);
        }
    }
}