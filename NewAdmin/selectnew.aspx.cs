﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewAdmin
{
    public partial class selectnew : System.Web.UI.Page
    {
        string txtBindDropDown = "";
        string txtContent = "";
        // string txtContentdd = "";
        string lblMessage = "";
        string txtServerContantSend = "";
        string txtServerContantRecived = "";
        string txtTableHeader = "";
        string txtTableBody = "";
        // string txtServerContantSenddd = "";
        string txtContentGrid = "";
        string txtGridHeader = "";
        List<string> objList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTableData();
                string tablename = drpTable.SelectedValue;
                //string Fieldname = drpFieldName.SelectedValue;
                BindFieldData(tablename);
                BindDropDownTopField(tablename);
                //BindDataType(tablename,Fieldname);

            }
        }

        public void BindTableData()
        {
            string data = "";

            string queryString = "select name  as TableName from sys.tables order by tablename;";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                drpTable.DataSource = reader;
                drpTable.DataValueField = "TableName";
                drpTable.DataTextField = "TableName";
                drpTable.DataBind();

                connection.Close();
            }
        }
        public void BindFieldData(string TableName)
        {
            string data = "";

            string queryString = "select C.Name as FiedlName from sys.columns C join sys.tables T on C.object_id=T.object_id WHERE t.name='" + TableName + "'";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Listview1.DataSource = reader;
                Listview1.DataBind();
                connection.Close();
            }
        }

        protected void Listview1_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Label lblFieldName = (Label)e.Item.FindControl("lblFieldName");
            Label lblDataType = (Label)e.Item.FindControl("lblDataType");
            Label lblIsnullavle = (Label)e.Item.FindControl("lblIsnullavle");
            CheckBox chbKey = (CheckBox)e.Item.FindControl("chbKey");
            DropDownList drpBindData = (DropDownList)e.Item.FindControl("drpBindData");
            DropDownList drpBindField = (DropDownList)e.Item.FindControl("drpBindField");
            //chbKey
            if (getPK(drpTable.SelectedItem.ToString(), lblFieldName.Text) == lblFieldName.Text)
                chbKey.Checked = true;
            string[] splitdata = BindDataType(drpTable.SelectedItem.ToString(), lblFieldName.Text).Split(',');
            lblDataType.Text = splitdata[0];
            lblIsnullavle.Text = splitdata[1];


            string queryString = "select name  as TableName from sys.tables;";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                drpBindData.DataSource = reader;
                drpBindData.DataTextField = "TableName";
                drpBindData.DataValueField = "TableName";
                drpBindData.DataBind();
                drpBindData.Items.Insert(0, new ListItem("-- Select --", "0"));
                drpBindField.Items.Insert(0, new ListItem("-- Select --", "0"));
                connection.Close();
            }


        }

        public string BindDataType(string TableName, string fieldName)
        {
            string data = "";

            string queryString = "SELECT DATA_TYPE,is_nullable FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + TableName + "' AND COLUMN_NAME = '" + fieldName + "'";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetValue(0).ToString();
                    data += "," + reader.GetValue(1).ToString();
                }
                connection.Close();
            }
            return data;
        }

        public string getPK(string TableName, string fieldName)
        {
            string data = "";

            string queryString = "SELECT column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE   OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 AND table_name = '" + TableName + "'";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data = reader.GetValue(0).ToString();
                    if (data == fieldName)
                        return data;
                }
                connection.Close();
            }
            return data;
        }

        public string RenameFieldname(string str)
        {
            return str.Replace('_', ' ').Replace("ID", " NAME").ToUpper();
        }

        protected void drpControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listview1.Items.Count; i++)
            {

                DropDownList drpControl = (DropDownList)Listview1.Items[i].FindControl("drpControl");
                DropDownList drpBindData = (DropDownList)Listview1.Items[i].FindControl("drpBindData");
                DropDownList drpBindField = (DropDownList)Listview1.Items[i].FindControl("drpBindField");
                if (drpControl.SelectedValue == "4")
                {
                    drpBindData.Enabled = true;
                    drpBindField.Enabled = true;
                }
                else
                {
                    drpBindData.Enabled = false;
                    drpBindField.Enabled = false;
                }
            }
        }
        protected void drpBindData_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listview1.Items.Count; i++)
            {
                DropDownList drpBindData = (DropDownList)Listview1.Items[i].FindControl("drpBindData");
                DropDownList drpBindField = (DropDownList)Listview1.Items[i].FindControl("drpBindField");
                string queryString = "select C.Name as FiedlName from sys.columns C join sys.tables T on C.object_id=T.object_id WHERE t.name='" + drpBindData.SelectedValue + "'";
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    drpBindField.DataSource = reader;
                    drpBindField.DataTextField = "FiedlName";
                    drpBindField.DataValueField = "FiedlName";
                    drpBindField.DataBind();
                    drpBindField.Items.Insert(0, new ListItem("-- Select --", "0"));

                    connection.Close();
                }
            }
        }

        public void BindDropDownTopField(string TableName)
        {
            string queryString = "select C.Name as FiedlName from sys.columns C join sys.tables T on C.object_id=T.object_id WHERE t.name='" + TableName + "'";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                drpBindTopField.DataSource = reader;
                drpBindTopField.DataTextField = "FiedlName";
                drpBindTopField.DataValueField = "FiedlName";
                drpBindTopField.DataBind();
                drpBindTopField.Items.Insert(0, new ListItem("-- Select --", "0"));
                connection.Close();
            }
        }

        protected void drpTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablename = drpTable.SelectedValue;
            BindFieldData(tablename);
            BindDropDownTopField(tablename);
        }

        protected void chkall_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listview1.Items.Count; i++)
            {
                CheckBox chk = (CheckBox)Listview1.Items[i].FindControl("CheckFields");
                if (checkall.Checked == true)
                    chk.Checked = true;
                else
                    chk.Checked = false;
            }
        }

        public void SetPage(string TableName)
        {
            #region Variable Declaration
            string root = Server.MapPath("~");
            string SaveFilePath = "";
            string SaveFileName = "";
            string SaveFilePathn = "";
            string SaveFileNamen = "";
            string SaveFilePathd = "";
            string SaveFileNamed = "";

            //string SaveFilePathGridView = "";
            //string SaveFileNameGridView = "";
            //string SaveFilePathnGridView = "";
            //string SaveFileNamenGridView = "";
            //string SaveFilePathnGridViewd = "";
            //string SaveFileNamenGridViewd = "";
            #endregion
            #region For ASPX file

            string Template = root + "\\temp\\PageTemplate2.temp";
            StringBuilder line = new StringBuilder();
            using (StreamReader rwOpenTemplate = new StreamReader(Template))
            {
                while (!rwOpenTemplate.EndOfStream)
                    line.Append(rwOpenTemplate.ReadToEnd());
            }
            #endregion
            #region For CS file
            string Templaten = root + "\\temp\\PageClass.temp";
            StringBuilder linen = new StringBuilder();
            using (StreamReader rwOpenTemplaten = new StreamReader(Templaten))
            {
                while (!rwOpenTemplaten.EndOfStream)
                    linen.Append(rwOpenTemplaten.ReadToEnd());
            }
            #endregion
            #region For aspx.designer file

            string Templated = root + "\\temp\\Designer.temp";
            StringBuilder lined = new StringBuilder();
            using (StreamReader rwOpenTemplated = new StreamReader(Templated))
            {
                while (!rwOpenTemplated.EndOfStream)
                    lined.Append(rwOpenTemplated.ReadToEnd());
            }
            #endregion
            #region Page Design Creator
            string Title = StripURLNotAllowedChars(TableName);
            SaveFileName = "\\" + Title + ".aspx";
            SaveFilePath = root + SaveFileName;
            FileStream fsSave = File.Create(SaveFilePath);



            if (line != null)
            {
  
                int selected = 0;

                txtContent = "<!--begin::Card body-->\r\n<div class=\"card-body p-9\">\r\n\t<!--begin::Row-->\r\n\t<div class=\"row mb-5\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-xl-3\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">Edit Table</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t</div>\r\n\t<!--end::Row-->";
                txtServerContantSend = "";
                txtServerContantRecived = "";
                txtContentGrid = "";
                txtGridHeader = "";
                txtTableHeader = "";
                txtTableBody = "";

                for (int j = 0; j < Listview1.Items.Count(); j++)
                {
                    Label lblFieldName = (Label)Listview1.Items[j].FindControl("lblFieldName");
                    CheckBox check = (CheckBox)Listview1.Items[j].FindControl("CheckFields");
                    DropDownList drpControl = (DropDownList)Listview1.Items[j].FindControl("drpControl");
                    CheckBox chMendatory = (CheckBox)Listview1.Items[j].FindControl("chMendatory");
                    DropDownList drpValidation = (DropDownList)Listview1.Items[j].FindControl("drpValidation");
                    TextBox txtLabelName = (TextBox)Listview1.Items[j].FindControl("txtLabelName");
                    //TextBox txtcolor = (TextBox)Listview1.Items[j].FindControl("txtcolor");
                    DropDownList drpBindData = (DropDownList)Listview1.Items[j].FindControl("drpBindData");
                    DropDownList drpBindField = (DropDownList)Listview1.Items[j].FindControl("drpBindField");
                    CheckBox chGriddata = (CheckBox)Listview1.Items[j].FindControl("chGriddata");
                    txtTableHeader += "<th class=\"min-w-50px\">" + lblFieldName.Text + "</th>\n\r";
                    txtTableBody += "<td> <%# Eval(\"" + lblFieldName.Text + "\")%> </td>\n\r";
                    if (check.Checked == true)
                    {
                        if (drpControl.SelectedValue == "1") // TextBox
                        {
                            txtContent += "<!--begin::Row--><div class=\"row mb-8\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">" + txtLabelName.Text + "</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6 fv-row\">\r\n\t\t\t<asp:TextBox ID=\"txt" + lblFieldName.Text + "\" runat=\"server\" class=\"form-control\" name=\"type\" value=\"\" ></asp:TextBox>\r\n\t\t</div>\r\n\t</div>\r\n\t<!--end::Row-->";
                        }
                        else if (drpControl.SelectedValue == "2") // TextBox with multiline
                        {
                            txtContent += "<!--begin::Row--><div class=\"row mb-8\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">" + txtLabelName.Text + "</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6 fv-row\">\r\n\t\t\t<asp:TextBox ID=\"txt" + lblFieldName.Text + "\" runat=\"server\" TextMode=\"MultiLine\" class=\"form-control\" name=\"type\" value=\"\" ></asp:TextBox>\r\n\t\t</div>\r\n\t</div>\r\n\t<!--end::Row-->";
                        }
                        else if (drpControl.SelectedValue == "3") // TextBox For DateTime
                        {
                            txtContent += "<!--begin::Row--><div class=\"row mb-8\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">" + txtLabelName.Text + "</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6 fv-row\">\r\n\t\t\t<asp:TextBox ID=\"txt" + lblFieldName.Text + "\" runat=\"server\"  Placeholder=\"MM/DD/YYYY\" class=\"form-control\" name=\"type\" value=\"\" ></asp:TextBox><cc1:CalendarExtender ID=\"TextBox" + lblFieldName.Text + "_CalendarExtender\" runat=\"server\" Enabled=\"True\" PopupButtonID=\"calender\" TargetControlID=\"txt" + lblFieldName.Text + "\"></cc1:CalendarExtender>\r\n\t\t</div>\r\n\t</div>\r\n\t<!--end::Row-->";
                        }
                        else if (drpControl.SelectedValue == "4") // DropDownList
                        {
                            txtContent += "<!--begin::Row--><div class=\"row mb-8\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">" + txtLabelName.Text + "</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6 fv-row\">\r\n\t\t\t<asp:DropDownList ID=\"drp" + lblFieldName.Text + "\" runat=\"server\" class=\"form-control\" name=\"type\" value=\"\" ></asp:DropDownList>\r\n\t\t</div>\r\n\t</div>\r\n\t<!--end::Row-->";
                        }
                        else if (drpControl.SelectedValue == "5") // CheckBox
                        {
                            txtContent += "<!--begin::Row--><div class=\"row mb-8\">\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"fs-6 fw-semibold mt-2 mb-3\">" + txtLabelName.Text + "</div>\r\n\t\t</div>\r\n\t\t<!--end::Col-->\r\n\t\t<!--begin::Col-->\r\n\t\t<div class=\"col-md-6\">\r\n\t\t\t<div class=\"d-flex fw-semibold h-100\">\r\n\t\t\t\t<div class=\"col-md-9\">\t\n\t\t\t\t<asp:checkbox ID=\"cb" + lblFieldName.Text + "\" class=\"form-check-input\" type=\"checkbox\" value=\"\" runat=\"server\" data-kt-check=\"true\" data-kt-check-target=\"[data-kt-settings-notification=phone]\" ></asp:checkbox>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t</div>\r\n\t\t<!--end::Row-->";
                        }
                        else
                        {
                           
                        }
                        if (chMendatory.Checked == true)
                        {
                            txtContent += ValidationStr(drpValidation.SelectedValue, txtLabelName.Text, lblFieldName.Text);
                        }

                        //Grid Data

                        if (chGriddata.Checked == true)
                        {
                            txtContentGrid += "<td> <asp:Label ID=\"lbl" + lblFieldName.Text + "\" runat=\"server\" Text='<%# Eval(\"" + lblFieldName.Text + "\")%>'></asp:Label></td>" + "\n";
                            txtGridHeader += "<th >" + txtLabelName.Text + "</th>" + "\n";
                        }

                    }
                    selected++;
                }

                txtContent += "</div>\r\n<!--end::Card body-->";

                if (selected < 1)
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "myscript", "alert('Must need to select at least one Table Name.');", true);
                    return;
                }
                //yogesh
                line.Replace("[TitleGridView]", TableName.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
                line.Replace("[PageContentGridView]", txtContentGrid);
                line.Replace("[PageContentGridViewField]", txtGridHeader);

                //yogesh
                line.Replace("[Title]", TableName.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
                line.Replace("[PageContent]", txtContent);
                line.Replace("[txtTableHeader]", txtTableHeader);
                line.Replace("[txtTableBody]", txtTableBody);
                SetStreamWriter(fsSave, line);
            }


            #endregion
            #region Page Server Side Creator
            txtBindDropDown = "";
            SaveFileNamen = "\\" + Title + ".aspx.cs";
            SaveFilePathn = root + SaveFileNamen;
            FileStream fsSavenn = File.Create(SaveFilePathn);
            if (linen != null)
            {
                //yogesh
                string ServerContentSend = "";
                string ServerContentRecived = "";
                string GridOrder = "";
                string queryVarcharServer = "select case user_type_id when 56 then 'obj'+T.Name+'.'+C.name+' = Convert.ToInt32(drp'+C.name+'.SelectedValue);' else case user_type_id when 61 then 'obj'+T.Name+'.'+C.name+' = Convert.ToDateTime(txt'+C.name+'.Text);' else case user_type_id when 106 then 'obj'+T.Name+'.'+C.name+' = Convert.ToDecimal(txt'+C.name+'.Text);' else case user_type_id when 104 then 'obj'+T.Name+'.'+C.name+' = cb'+C.name+'.Checked;'  else 'obj'+T.Name+'.'+C.name+' = txt'+C.name+'.Text;' end end end end as Send ,case user_type_id when 104 then 'cb'+C.name+'.Checked = (obj'+T.Name+'.'+C.name+'== true) ? true : false;' else case user_type_id when 56 then 'drp'+C.name+'.SelectedValue = obj'+T.Name+'.'+C.name+'.ToString();' else 'txt'+C.name+'.Text = obj'+T.Name+'.'+C.name+'.ToString();' end end as Recieve from sys.columns C join sys.tables T on C.object_id=T.object_id where  C.user_type_id in(SELECT user_type_id FROM sys.types)  and T.name='" + TableName + "' and column_id BETWEEN 2 AND (SELECT COUNT(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + TableName + "')-4 order by T.Name;";
                using (SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["CRMNewEntitiesNew"].ConnectionString))
                {
                    SqlCommand command2 = new SqlCommand(queryVarcharServer, connection2);
                    connection2.Open();
                    SqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        ServerContentSend = String.Format("{0}", reader2[0]);
                        ServerContentRecived = String.Format("{0}", reader2[1]);
                        txtServerContantSend += ServerContentSend + "\n";
                        txtServerContantRecived += ServerContentRecived + "\n";




                    }
                    for (int j = 0; j < Listview1.Items.Count(); j++)
                    {
                        DropDownList drpBindData = (DropDownList)Listview1.Items[j].FindControl("drpBindData");
                        Label lblFieldName = (Label)Listview1.Items[j].FindControl("lblFieldName");
                        DropDownList drpBindField = (DropDownList)Listview1.Items[j].FindControl("drpBindField");
                        txtBindDropDown = "drp" + lblFieldName.Text + ".Items.Insert(0, new ListItem(\"-- Select --\", \"0\"));drp" + lblFieldName.Text + ".DataSource = DB." + drpBindData.SelectedValue + ";drp" + lblFieldName.Text + ".DataTextField = \"" + drpBindField.SelectedValue + "\";drp" + lblFieldName.Text + ".DataValueField = \"" + drpBindField.SelectedValue + "\";drp" + lblFieldName.Text + ".DataBind();";
                    }

                    connection2.Close();
                }

                //Grid Order
                if (droOrder.SelectedValue == "2")
                    GridOrder = ".OrderByDescending(p=>p." + drpBindTopField.SelectedValue + ")";
                else if (droOrder.SelectedValue == "1")
                    GridOrder = ".OrderBy(p=>p." + drpBindTopField.SelectedValue + ")";
                else
                { }
                linen.Replace("[Title]", TableName.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
                linen.Replace("[OrderBy]", GridOrder);
                linen.Replace("[ServerContentSend]", txtServerContantSend);
                linen.Replace("[ServerContentRecived]", txtServerContantRecived);
                linen.Replace("[BindDropDown123]", txtBindDropDown);
                SetStreamWriter(fsSavenn, linen);

            }
            #endregion
            #region Page aspx.designer Creator
            SaveFileNamed = "\\" + Title + ".aspx.designer.cs";
            SaveFilePathd = root + SaveFileNamed;
            FileStream fsSavend = File.Create(SaveFilePathd);
            if (lined != null)
            {
                lined.Replace("[Title]", TableName.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
                SetStreamWriter(fsSavend, lined);

            }
            #endregion
        }

        public string ValidationStr(string drp, string Label, string IDName)
        {
            string contact = "";
            if (drp == "1")//Numeric Only Validation
            {
                contact = "<cc1:FilteredTextBoxExtender ID=\"FilteredTextBoxExtender" + IDName + "\" TargetControlID=\"txtticketentitled\" FilterType=\"Custom, numbers\"  runat=\"server\" /> ";
            }
            else if (drp == "2")//Numeric with Dott Validation  
            {
                contact = "<cc1:FilteredTextBoxExtender ValidChars=\".\" ID=\"FilteredTextBoxExtender" + IDName + "\" TargetControlID=\"txtticketentitled\" FilterType=\"Custom, numbers\"  runat=\"server\" /> ";
            }
            else if (drp == "3")//Drop Box Validation
            {
                contact = " <asp:RequiredFieldValidator CssClass=\"Validation\" ID=\"RequiredFieldValidator" + IDName + "\" runat=\"server\" ErrorMessage=\"" + Label + " Required.\" ControlToValidate=\"drp" + IDName + "\" ValidationGroup=\"submit\" InitialValue=\"0\"></asp:RequiredFieldValidator>";
            }
            else if (drp == "4")//Email Validation
            {
                contact = " <asp:RequiredFieldValidator ID=\"RequiredFieldValidator" + IDName + "\" runat=\"server\" ControlToValidate=\"txt" + IDName + "\" ErrorMessage=\"Email Required\" ValidationGroup=\"Submit\" CssClass=\"Validation\"></asp:RequiredFieldValidator> <asp:RegularExpressionValidator ID=\"RegularExpressionValidator1\" runat=\"server\" ValidationGroup=\"Submit\" CssClass=\"Validation\" ErrorMessage=\"Email not Valid\" ControlToValidate=\"txt" + IDName + "\" ValidationExpression=\"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\"></asp:RegularExpressionValidator> ";
            }
            else if (drp == "5")//Required Validation
            {
                contact = "<asp:RequiredFieldValidator ID=\"RequiredFieldValidator" + IDName + "\" runat=\"server\" ControlToValidate=\"txt'" + IDName + "\" ErrorMessage=\"" + Label + " Required.\" CssClass=\"Validation\" ValidationGroup=\"s\"></asp:RequiredFieldValidator>";
            }
            else if (drp == "6")//Date Time Validation
            {
                contact = " <asp:RequiredFieldValidator ID=\"RequiredFieldValidator" + IDName + "\" runat=\"server\" ControlToValidate=\"txt" + IDName + "\" ErrorMessage=\"" + Label + " Required.\" CssClass=\"Validation\" ValidationGroup=\"Submit\"></asp:RequiredFieldValidator> <cc1:filteredtextboxextender id=\"FilteredTextBoxExtender2\" targetcontrolid=\"txt" + IDName + "\" ValidChars=\"/\"    filtertype=\"Custom, numbers\" runat=\"server\" /> ";
            }
            else
            {

            }
            return contact;
        }

        private string StripURLNotAllowedChars(string htmlString)
        {
            string pattern = @"\s|\#|\$|\&|\||\!|\@|\%|\^|\*|\<\|\>|\\|\/|\+|\-|\=";
            return Regex.Replace(htmlString, pattern, "-");
        }
        public void SetStreamWriter(FileStream FS, StringBuilder SB)
        {
            StreamWriter swn = null;
            try
            {
                swn = new StreamWriter(FS);
                swn.Write(SB);
            }
            catch (Exception ex)
            {
                lblMessage = ex.Message;
            }
            finally
            {
                swn.Close();
            }
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            SetPage(drpTable.SelectedValue);
        }
    }
}