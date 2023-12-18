using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplications
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }

        protected void GetData()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT TOP 15 CustomerId, ContactName From CustomersCopy", con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    ListBox1.DataSource = rdr;
                    ListBox1.DataTextField = "ContactName";
                    ListBox1.DataValueField = "CustomerId";
                    ListBox1.DataBind();
                }
            }
        }

        protected void GetDataById(string id)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "SELECT CompanyName, ContactName,ContactTitle, City, PostalCode From CustomersCopy where CustomerID=" + "'" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        CompanyName.Text = rdr["CompanyName"].ToString();
                        ContactName.Text = rdr["ContactName"].ToString();
                        ContactTitle.Text = rdr["ContactTitle"].ToString();
                        City.Text = rdr["City"].ToString();
                        PostalCode.Text = rdr["PostalCode"].ToString();
                    }
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataById(ListBox1.SelectedValue);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "Delete CustomersCopy where CustomerID=" + "'" + ListBox1.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                CompanyName.Text = "";
                ContactName.Text = "";
                ContactTitle.Text = "";
                City.Text = "";
                PostalCode.Text = "";
                GetData();
            }
        }


        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "Update CustomersCopy set CompanyName=@CompanyName, ContactName=@ContactName, ContactTitle=@ContactTitle, City=@City, PostalCode=@PostalCode where CustomerID=@Id";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@CompanyName", CompanyName.Text);
                cmd.Parameters.AddWithValue("@ContactName", ContactName.Text);
                cmd.Parameters.AddWithValue("@ContactTitle", ContactTitle.Text);
                cmd.Parameters.AddWithValue("@City", City.Text);
                cmd.Parameters.AddWithValue("@PostalCode", PostalCode.Text);
                cmd.Parameters.AddWithValue("@Id", ListBox1.SelectedValue);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                CompanyName.Text = "";
                ContactName.Text = "";
                ContactTitle.Text = "";
                City.Text = "";
                PostalCode.Text = "";
                GetData();
            }
        }
    }
}