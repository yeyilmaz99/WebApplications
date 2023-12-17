using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplications
{
    public partial class CascadingDropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            {
                ddlCategories.DataSource =  GetData("spGetCategories", null);
                ddlCategories.DataValueField = "CategoryId";
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataBind();

                ListItem liCategory = new ListItem("Select Category", "-1");
                ddlCategories.Items.Insert(0, liCategory);
                ListItem liProducts = new ListItem("Select Product", "-1");
                ddlProducts.Items.Insert(0, liProducts);

                ddlProducts.Enabled = false;    
            }
        }
        private DataSet GetData(string SPName, SqlParameter SPParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);

            if(SPParameter != null )
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet DS = new DataSet();

            da.Fill(DS);
            return DS;
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlCategories.SelectedIndex == 0)
            {
                ddlProducts.Enabled = false;
                ddlProducts.SelectedValue = "0";
            }
            else
            {
                ddlProducts.Enabled = true;
                SqlParameter parameter = new SqlParameter("@CategoryId", ddlCategories.SelectedValue);
                DataSet DS = GetData("spGetProductsByCategoryId", parameter);

                ddlProducts.DataSource = DS;
                ddlProducts.DataTextField = "ProductName";
                ddlProducts.DataValueField = "ProductId";
                ddlProducts.DataBind();
                ListItem liProducts = new ListItem("Select Product", "-1");
                ddlProducts.Items.Insert(0, liProducts);

            }
            
        }
    }
}