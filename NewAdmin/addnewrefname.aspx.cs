using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace NewAdmin
{
    public partial class addnewrefname : System.Web.UI.Page
    {
        atyaabEntities db = new atyaabEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["reftype"] != null && Request.QueryString["refsubtype"] != null)
                {
                    string reftype = Request.QueryString["reftype"].ToString();
                    string refsubtype = Request.QueryString["refsubtype"].ToString();
                    int TenentID = Convert.ToInt32(Request.QueryString["TenentID"]);
                    lblheader.Text = reftype + " and " + refsubtype;
                    bindref();
                    bindlastref();
                }
            }
        }

        public void bindref()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string reftype = Request.QueryString["reftype"].ToString();
                string refsubtype = Request.QueryString["refsubtype"].ToString();
                int TenentID = Convert.ToInt32(Request.QueryString["TenentID"]);
                string query = @"SELECT * from Reftable where TenentID = " + TenentID + " and  reftype = '" + reftype + "' and refsubtype= '" + refsubtype + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listreftable.DataSource = dt;
                listreftable.DataBind();
            }
        }

        public void bindlastref()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string reftype = Request.QueryString["reftype"].ToString();
                string refsubtype = Request.QueryString["refsubtype"].ToString();
                int TenentID = Convert.ToInt32(Request.QueryString["TenentID"]);
                var listj = db.REFTABLEs.Where(p => p.TenentID == TenentID && p.REFTYPE == reftype && p.REFSUBTYPE == refsubtype).OrderByDescending(p => p.REFID).Take(1).ToList();
                listlastitem.DataSource = listj;
                listlastitem.DataBind();
            }
        }

        protected void listlastitem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdnew")
            {
                lblSaveMessage.Visible = false;
                pnlref.Visible = true;
            }
        }

        protected void btnsaveitem_Click(object sender, EventArgs e)
        {
            try
            {
                string reftype = Request.QueryString["reftype"].ToString();
                string refsubtype = Request.QueryString["refsubtype"].ToString();
                int TenentID = Convert.ToInt32(Request.QueryString["TenentID"]);

                // Determine the next refID
                int refID = db.REFTABLEs.Where(p => p.TenentID == TenentID && p.REFTYPE == reftype && p.REFSUBTYPE == refsubtype).Count() > 0
                            ? Convert.ToInt32(db.REFTABLEs.Where(p => p.TenentID == TenentID && p.REFTYPE == reftype && p.REFSUBTYPE == refsubtype).Max(p => p.REFID) + 1)
                            : 1;

                // Create new REFTABLE object
                REFTABLE objref = new REFTABLE
                {
                    TenentID = TenentID,
                    REFID = refID,
                    REFTYPE = reftype,
                    REFSUBTYPE = refsubtype,
                    SHORTNAME = txtshortname.Text,
                    REFNAME1 = txtrefname.Text,
                    REFNAME2 = txtrefname.Text,
                    REFNAME3 = txtrefname.Text,
                    ACTIVE = "Y",
                    UploadDate = DateTime.Now
                };

                // Add and save the new object to the database
                db.REFTABLEs.Add(objref);
                db.SaveChanges();

                // Show success message
                lblSaveMessage.Text = "Item saved successfully!";
                lblSaveMessage.Visible = true;
                pnlref.Visible = false;
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                lblSaveMessage.Text = "An error occurred: " + ex.Message;
                lblSaveMessage.ForeColor = System.Drawing.Color.Red;
                lblSaveMessage.Visible = true;
            }

            // Re-bind the data to reflect changes
            bindlastref();
        }
    }
}