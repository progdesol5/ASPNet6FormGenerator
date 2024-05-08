using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Linq;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Transactions;
using Database;
namespace NewAdmin
{
public partial class tbl_DefineLeavePeriod : System.Web.UI.Page
{
    ERPEntities DB = new ERPEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
	 if (!IsPostBack)
        {
		pnlSuccessMsg.Visible = false;
		 FillContractorID();
                int CurrentID = 1;
                if (ViewState["Es"] != null)
                {
                    CurrentID = Convert.ToInt32(ViewState["Es"]);
                }
			BindData();
			
			if (Request.QueryString.Count > 0)
			{
				int ID = Convert.ToInt32(Request.QueryString["ID"]);
				Database.tbl_DefineLeavePeriod objtbl_DefineLeavePeriod = DB.tbl_DefineLeavePeriod.Single(p=>p.ID == ID);
				//Server Content Recived data Yogesh
				drpStartMonth.SelectedValue = objtbl_DefineLeavePeriod.StartMonth.ToString();
drpStartDate.SelectedValue = objtbl_DefineLeavePeriod.StartDate.ToString();
 
			}
        }
    }
	public void BindData()
    {
	        Listview1.DataSource = DB.tbl_DefineLeavePeriod.OrderBy(p=>p.ID);
            Listview1.DataBind();
	}
	protected void ListProduct_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                if (e.CommandName == "btnDelete")
                {
                    int ID = Convert.ToInt32(e.CommandArgument);
                    Database.tbl_DefineLeavePeriod objtbl_DefineLeavePeriod = DB.tbl_DefineLeavePeriod.Single(p => p.ID == ID);
                    objtbl_DefineLeavePeriod.Deleted = false;
                   
                    DB.SaveChanges();
					DataBind();
                    Response.Redirect("tbl_DefineLeavePeriod.aspx");
                }
				 if (e.CommandName == "btnEdit")
                    {
                        int ID = Convert.ToInt32(e.CommandArgument);
				        select_data(ID);
					}
					scope.Complete(); //  To commit.
				}
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
		
    protected void select_data(int ID)
    {
        Database.tbl_DefineLeavePeriod objtbl_DefineLeavePeriod = DB.tbl_DefineLeavePeriod.Single(p=>p.ID == ID);
		drpStartMonth.SelectedValue = objtbl_DefineLeavePeriod.StartMonth.ToString();
drpStartDate.SelectedValue = objtbl_DefineLeavePeriod.StartDate.ToString();
 
		ViewState["Edit"] = ID;
    }

	protected void btnSave_Click(object sender, EventArgs e)
    {
	 using (TransactionScope scope = new TransactionScope())
            {
                try
                {
						 if (ViewState["Edit"] != null)
                        {
							int ID = Convert.ToInt32(ViewState["Edit"]);
							Database.tbl_DefineLeavePeriod objtbl_DefineLeavePeriod = DB.tbl_DefineLeavePeriod.Single(p => p.ID == ID);
							objtbl_DefineLeavePeriod.StartMonth = Convert.ToInt32(drpStartMonth.SelectedValue);
objtbl_DefineLeavePeriod.StartDate = Convert.ToInt32(drpStartDate.SelectedValue);
 

					        ViewState["Edit"] = null;
                            btnAdd.Text = "Add New";
                        
						}
						else
						{
							Database.tbl_DefineLeavePeriod objtbl_DefineLeavePeriod = new Database.tbl_DefineLeavePeriod();
							//Server Content Send data Yogesh
							objtbl_DefineLeavePeriod.StartMonth = Convert.ToInt32(drpStartMonth.SelectedValue);
objtbl_DefineLeavePeriod.StartDate = Convert.ToInt32(drpStartDate.SelectedValue);

							
							DB.tbl_DefineLeavePeriod.AddObject(objtbl_DefineLeavePeriod);
						}
						DB.SaveChanges();
						
				scope.Complete(); //  To commit.
                DataBind();

				lblMsg.Text = "  Data Edit Successfully";
                Response.Redirect("tbl_AddCustomer.aspx");
                pnlSuccessMsg.Visible = true;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
	protected void btnCancel_Click(object sender, EventArgs e)
    {
       Response.Redirect("index.aspx");
    }

	public void FillContractorID()
    {
	//	drpCreateDate.Items.Insert(0, new ListItem("-- Select --", "0"));drpCreateDate.DataSource = DB.0;drpCreateDate.DataTextField = "0";drpCreateDate.DataValueField = "0";drpCreateDate.DataBind();
	}
    protected void btnFirst_Click(object sender, EventArgs e)
    {
        FirstData();
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        NextData();
    }
    protected void btnPrev_Click(object sender, EventArgs e)
    {
        PrevData();
    }
    protected void btnLast_Click(object sender, EventArgs e)
    {
        LastData();
    }
		public void FirstData()
    {
        int index = Convert.ToInt32(ViewState["Index"]);
        Listview1.SelectedIndex = 0;
		//code
        select_data(Listview1.SelectedIndex);
	}
	public void NextData()
    {

        if (Listview1.SelectedIndex != Listview1.Items.Count - 1)
        {
            Listview1.SelectedIndex = Listview1.SelectedIndex + 1;
			//code
		}
        select_data(Listview1.SelectedIndex);
			
	}
	public void PrevData()
    {
		if (Listview1.SelectedIndex == 0)
        {
            lblMsg.Text = "This is first record";
            pnlSuccessMsg.Visible = true;
			//code
        }
        else
        {
            pnlSuccessMsg.Visible = false;
            Listview1.SelectedIndex = Listview1.SelectedIndex - 1;
			//code
		}
        select_data(Listview1.SelectedIndex);
     }
	public void LastData()
    {
        Listview1.SelectedIndex = Listview1.Items.Count - 1;
		//code
        select_data(Listview1.SelectedIndex);
	}
}
}
