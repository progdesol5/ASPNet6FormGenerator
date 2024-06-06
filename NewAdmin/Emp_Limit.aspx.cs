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
public partial class Emp_Limit : System.Web.UI.Page
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
				Database.Emp_Limit objEmp_Limit = DB.Emp_Limit.Single(p=>p.ID == ID);
				//Server Content Recived data Yogesh
				drpPID.SelectedValue = objEmp_Limit.PID.ToString();
drpEmployeeID.SelectedValue = objEmp_Limit.EmployeeID.ToString();
txtEmployee_name.Text = objEmp_Limit.Employee_name.ToString();
txtEmp_dept.Text = objEmp_Limit.Emp_dept.ToString();
txtEmp_Manager.Text = objEmp_Limit.Emp_Manager.ToString();
txtEmp_Limitnew.Text = objEmp_Limit.Emp_Limitnew.ToString();
drpPrevious_emp_limit_no.SelectedValue = objEmp_Limit.Previous_emp_limit_no.ToString();
txtPrevious_emp_Limit1.Text = objEmp_Limit.Previous_emp_Limit1.ToString();
txtPrevious_emp_Limit2.Text = objEmp_Limit.Previous_emp_Limit2.ToString();
txtPrevious_emp_limit3.Text = objEmp_Limit.Previous_emp_limit3.ToString();
txtPrevious_emp_limit4.Text = objEmp_Limit.Previous_emp_limit4.ToString();
txtPrevious_emp_limit5.Text = objEmp_Limit.Previous_emp_limit5.ToString();
txtcreated_date.Text = objEmp_Limit.created_date.ToString();
txtrevised_date1.Text = objEmp_Limit.revised_date1.ToString();
txtrevised_date2.Text = objEmp_Limit.revised_date2.ToString();
txtrevised_date3.Text = objEmp_Limit.revised_date3.ToString();
 
			}
        }
    }
	public void BindData()
    {
	        Listview1.DataSource = DB.Emp_Limit;
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
                    Database.Emp_Limit objEmp_Limit = DB.Emp_Limit.Single(p => p.ID == ID);
                    objEmp_Limit.Deleted = false;
                   
                    DB.SaveChanges();
					DataBind();
                    Response.Redirect("Emp_Limit.aspx");
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
        Database.Emp_Limit objEmp_Limit = DB.Emp_Limit.Single(p=>p.ID == ID);
		drpPID.SelectedValue = objEmp_Limit.PID.ToString();
drpEmployeeID.SelectedValue = objEmp_Limit.EmployeeID.ToString();
txtEmployee_name.Text = objEmp_Limit.Employee_name.ToString();
txtEmp_dept.Text = objEmp_Limit.Emp_dept.ToString();
txtEmp_Manager.Text = objEmp_Limit.Emp_Manager.ToString();
txtEmp_Limitnew.Text = objEmp_Limit.Emp_Limitnew.ToString();
drpPrevious_emp_limit_no.SelectedValue = objEmp_Limit.Previous_emp_limit_no.ToString();
txtPrevious_emp_Limit1.Text = objEmp_Limit.Previous_emp_Limit1.ToString();
txtPrevious_emp_Limit2.Text = objEmp_Limit.Previous_emp_Limit2.ToString();
txtPrevious_emp_limit3.Text = objEmp_Limit.Previous_emp_limit3.ToString();
txtPrevious_emp_limit4.Text = objEmp_Limit.Previous_emp_limit4.ToString();
txtPrevious_emp_limit5.Text = objEmp_Limit.Previous_emp_limit5.ToString();
txtcreated_date.Text = objEmp_Limit.created_date.ToString();
txtrevised_date1.Text = objEmp_Limit.revised_date1.ToString();
txtrevised_date2.Text = objEmp_Limit.revised_date2.ToString();
txtrevised_date3.Text = objEmp_Limit.revised_date3.ToString();
 
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
							Database.Emp_Limit objEmp_Limit = DB.Emp_Limit.Single(p => p.ID == ID);
							objEmp_Limit.PID = Convert.ToInt32(drpPID.SelectedValue);
objEmp_Limit.EmployeeID = Convert.ToInt32(drpEmployeeID.SelectedValue);
objEmp_Limit.Employee_name = txtEmployee_name.Text;
objEmp_Limit.Emp_dept = txtEmp_dept.Text;
objEmp_Limit.Emp_Manager = txtEmp_Manager.Text;
objEmp_Limit.Emp_Limitnew = Convert.ToDecimal(txtEmp_Limitnew.Text);
objEmp_Limit.Previous_emp_limit_no = Convert.ToInt32(drpPrevious_emp_limit_no.SelectedValue);
objEmp_Limit.Previous_emp_Limit1 = Convert.ToDecimal(txtPrevious_emp_Limit1.Text);
objEmp_Limit.Previous_emp_Limit2 = Convert.ToDecimal(txtPrevious_emp_Limit2.Text);
objEmp_Limit.Previous_emp_limit3 = Convert.ToDecimal(txtPrevious_emp_limit3.Text);
objEmp_Limit.Previous_emp_limit4 = Convert.ToDecimal(txtPrevious_emp_limit4.Text);
objEmp_Limit.Previous_emp_limit5 = Convert.ToDecimal(txtPrevious_emp_limit5.Text);
objEmp_Limit.created_date = Convert.ToDateTime(txtcreated_date.Text);
objEmp_Limit.revised_date1 = Convert.ToDateTime(txtrevised_date1.Text);
objEmp_Limit.revised_date2 = Convert.ToDateTime(txtrevised_date2.Text);
objEmp_Limit.revised_date3 = Convert.ToDateTime(txtrevised_date3.Text);
 

					        ViewState["Edit"] = null;
                            btnAdd.Text = "Add New";
                        
						}
						else
						{
							Database.Emp_Limit objEmp_Limit = new Database.Emp_Limit();
							//Server Content Send data Yogesh
							objEmp_Limit.PID = Convert.ToInt32(drpPID.SelectedValue);
objEmp_Limit.EmployeeID = Convert.ToInt32(drpEmployeeID.SelectedValue);
objEmp_Limit.Employee_name = txtEmployee_name.Text;
objEmp_Limit.Emp_dept = txtEmp_dept.Text;
objEmp_Limit.Emp_Manager = txtEmp_Manager.Text;
objEmp_Limit.Emp_Limitnew = Convert.ToDecimal(txtEmp_Limitnew.Text);
objEmp_Limit.Previous_emp_limit_no = Convert.ToInt32(drpPrevious_emp_limit_no.SelectedValue);
objEmp_Limit.Previous_emp_Limit1 = Convert.ToDecimal(txtPrevious_emp_Limit1.Text);
objEmp_Limit.Previous_emp_Limit2 = Convert.ToDecimal(txtPrevious_emp_Limit2.Text);
objEmp_Limit.Previous_emp_limit3 = Convert.ToDecimal(txtPrevious_emp_limit3.Text);
objEmp_Limit.Previous_emp_limit4 = Convert.ToDecimal(txtPrevious_emp_limit4.Text);
objEmp_Limit.Previous_emp_limit5 = Convert.ToDecimal(txtPrevious_emp_limit5.Text);
objEmp_Limit.created_date = Convert.ToDateTime(txtcreated_date.Text);
objEmp_Limit.revised_date1 = Convert.ToDateTime(txtrevised_date1.Text);
objEmp_Limit.revised_date2 = Convert.ToDateTime(txtrevised_date2.Text);
objEmp_Limit.revised_date3 = Convert.ToDateTime(txtrevised_date3.Text);

							
							DB.Emp_Limit.AddObject(objEmp_Limit);
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
	//	drpMPC_Number.Items.Insert(0, new ListItem("-- Select --", "0"));drpMPC_Number.DataSource = DB.0;drpMPC_Number.DataTextField = "0";drpMPC_Number.DataValueField = "0";drpMPC_Number.DataBind();
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
