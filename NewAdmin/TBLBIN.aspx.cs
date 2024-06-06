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
namespace NewAdmin
{
public partial class TBLBIN : System.Web.UI.Page
{
    atyaabEntities DB = new atyaabEntities();
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
				TBLBIN objTBLBIN = DB.TBLBINs.Single(p=>p.BIN_ID == ID);
				//Server Content Recived data Yogesh
				drpBIN_ID.SelectedValue = objTBLBIN.BIN_ID.ToString();
drpMyComLocID.SelectedValue = objTBLBIN.MyComLocID.ToString();
txtBINDesc1.Text = objTBLBIN.BINDesc1.ToString();
txtBINDesc2.Text = objTBLBIN.BINDesc2.ToString();
 
			}
        }
    }
	public void BindData()
    {
            var list = DB.TBLBINs.OrderBy(p=>p.BIN_ID).ToList();
	        Listview1.DataSource = list;
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
                    TBLBIN objTBLBIN = DB.TBLBINs.Single(p => p.BIN_ID == ID);
                    DB.TBLBINs.Remove(objTBLBIN);
                    DB.SaveChanges();
					DataBind();
                    Response.Redirect("TBLBIN.aspx");
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
       TBLBIN objTBLBIN = DB.TBLBINs.Single(p=>p.BIN_ID == ID);
		drpBIN_ID.SelectedValue = objTBLBIN.BIN_ID.ToString();
drpMyComLocID.SelectedValue = objTBLBIN.MyComLocID.ToString();
txtBINDesc1.Text = objTBLBIN.BINDesc1.ToString();
txtBINDesc2.Text = objTBLBIN.BINDesc2.ToString();
 
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
							TBLBIN objTBLBIN = DB.TBLBINs.Single(p => p.BIN_ID == ID);
							objTBLBIN.BIN_ID = Convert.ToInt32(drpBIN_ID.SelectedValue);
                            objTBLBIN.MyComLocID = Convert.ToInt32(drpMyComLocID.SelectedValue);
                            objTBLBIN.BINDesc1 = txtBINDesc1.Text;
                            objTBLBIN.BINDesc2 = txtBINDesc2.Text; 

					        ViewState["Edit"] = null;
                            btnAdd.Text = "Add New";
                        
						}
						else
						{
							TBLBIN objTBLBIN = new TBLBIN();
							//Server Content Send data Yogesh
							objTBLBIN.BIN_ID = Convert.ToInt32(drpBIN_ID.SelectedValue);
objTBLBIN.MyComLocID = Convert.ToInt32(drpMyComLocID.SelectedValue);
objTBLBIN.BINDesc1 = txtBINDesc1.Text;
objTBLBIN.BINDesc2 = txtBINDesc2.Text;

							
							DB.TBLBINs.Add(objTBLBIN);
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
	//	drpCRUP_ID.Items.Insert(0, new ListItem("-- Select --", "0"));drpCRUP_ID.DataSource = DB.0;drpCRUP_ID.DataTextField = "0";drpCRUP_ID.DataValueField = "0";drpCRUP_ID.DataBind();
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
