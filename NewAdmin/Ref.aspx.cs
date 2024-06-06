using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewAdmin
{
    public partial class Ref : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindreftable();
                bindtenent();
            }
        }


        public void bindreftable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT DISTINCT TenentID, REFTYPE,REFSUBTYPE FROM REFTABLE order by TenentID";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                listreftable.DataSource = dt;
                listreftable.DataBind();
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {


            string connectionString = ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string tenent = drptenent.SelectedValue;
                string reftype = drpreftype.SelectedValue;

                if(tenent != "0" && reftype !="0")
                {
                    string query = @"SELECT DISTINCT TenentID, REFTYPE,REFSUBTYPE from Reftable where TenentID = " + tenent + " and REFTYPE= '" + reftype + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    listreftable.DataSource = dt;
                    listreftable.DataBind();
                }
                else
                {
                    string query = @"SELECT DISTINCT TenentID, REFTYPE,REFSUBTYPE FROM REFTABLE order by TenentID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    listreftable.DataSource = dt;
                    listreftable.DataBind();
                }
               
            }
        }

        public void bindtenent()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;
            string query = "SELECT DISTINCT TenentID FROM REFTABLE order by TenentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    drptenent.DataSource = reader;
                    drptenent.DataTextField = "TenentID";
                    drptenent.DataValueField = "TenentID";
                    drptenent.DataBind();
                }
            }
            drptenent.Items.Insert(0, new ListItem("--Select Tenent--", "0"));
        }

        protected void drptenent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drptenent.SelectedValue == "0")
            {

            }
            else
            {
                string tenent = drptenent.SelectedValue;
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;
                string query = "SELECT DISTINCT REFTYPE FROM REFTABLE where TenentID = " + tenent + "";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        drpreftype.DataSource = reader;
                        drpreftype.DataTextField = "REFTYPE";
                        drpreftype.DataValueField = "REFTYPE";
                        drpreftype.DataBind();
                    }
                }
                drpreftype.Items.Insert(0, new ListItem("--Select Reftype--", ""));
            }
           
        }
    }
}