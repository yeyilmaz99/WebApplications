using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class dropdownDataBind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select CategoryId, CategoryName from Categories", con);

                    con.Open();
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "CategoryName";
                    DropDownList1.DataValueField = "CategoryId";
                    DropDownList1.DataBind();

                    ListItem li = new ListItem("Select Item", "-1");
                    DropDownList1.Items.Insert(0,li);

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(DropDownList1.SelectedValue == "-1")
            {
                Response.Write("Please Select A Category first");
            }
            else
            {

                Response.Write(DropDownList1.SelectedItem.Text + "<br/>");
                Response.Write(DropDownList1.SelectedItem.Value + "<br/>");
                Response.Write(DropDownList1.SelectedIndex + "<br/>");
                Response.Write(DropDownList1.SelectedValue + "<br/>");
            }

        }
    }
}