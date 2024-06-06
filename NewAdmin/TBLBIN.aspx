<%@ Page Title="" Language="C#" MasterPageFile="~/NewAcmMaster.master" AutoEventWireup="true" CodeBehind="TBLBIN.aspx.cs" Inherits="NewAdmin.TBLBIN"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="app-main flex-column flex-row-fluid" id="kt_app_main">
        <!--begin::Content wrapper-->
        <div class="d-flex flex-column flex-column-fluid">
            <!--begin::Toolbar-->
            <div id="kt_app_toolbar" class="app-toolbar py-3 py-lg-6">
               <asp:Panel ID="pnlSuccessMsg" runat="server" Visible="false">
                    <div class="alert alert-success alert-dismissable">
                        <button aria-hidden="true" data-dismiss="alert" class="close" type="button"></button>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </div>
                </asp:Panel>
            </div>
            <div id="kt_app_content" class="app-content flex-column-fluid">
                <div id="kt_app_content_container" class="app-container container-xxl">
                    <div id="kt_ecommerce_edit_order_form" class="form d-flex flex-column flex-lg-row" data-kt-redirect="apps/ecommerce/sales/listing.html">                        
                        <div class="col-md-12" style="width: 1500px;">                            
                            <div class="card card-flush py-4">                                
                                <div class="card-header">
                                    <div class="card-title">
                                        <h2>TBLBIN</h2>
                                    </div>
                                </div>
                                <div class="card-body pt-0">
                                    <div class="d-flex flex-column gap-10">
                                        <div class="row">
                                           <!--begin::Card body-->
<div class="card-body p-9">
	<!--begin::Row-->
	<div class="row mb-5">
		<!--begin::Col-->
		<div class="col-xl-3">
			<div class="fs-6 fw-semibold mt-2 mb-3">Edit Table</div>
		</div>
		<!--end::Col-->
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">TENENT NAME</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:DropDownList ID="drpTenentID" runat="server" class="form-control" name="type" value="" ></asp:DropDownList>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">BIN  NAME</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:DropDownList ID="drpBIN_ID" runat="server" class="form-control" name="type" value="" ></asp:DropDownList>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">MYCOMLOC NAME</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:DropDownList ID="drpMyComLocID" runat="server" class="form-control" name="type" value="" ></asp:DropDownList>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">BINDESC1</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:TextBox ID="txtBINDesc1" runat="server" class="form-control" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">BINDESC2</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:TextBox ID="txtBINDesc2" runat="server" class="form-control" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">BINREMARKS</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:TextBox ID="txtBINRemarks" runat="server" TextMode="MultiLine" class="form-control" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">BINREQMAINTENACE</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:TextBox ID="txtBinReqMaintenace" runat="server" class="form-control" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">ACTIVE</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="d-flex fw-semibold h-100">
				<div class="col-md-9">	
				<asp:checkbox ID="cbACTIVE" class="form-check-input" type="checkbox" value="" runat="server" data-kt-check="true" data-kt-check-target="[data-kt-settings-notification=phone]" ></asp:checkbox>
			</div>
		</div>
		</div>
		<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--begin::Col-->
		<div class="col-md-6">
			<div class="fs-6 fw-semibold mt-2 mb-3">CRUP  NAME</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-md-6 fv-row">
			<asp:DropDownList ID="drpCRUP_ID" runat="server" class="form-control" name="type" value="" ></asp:DropDownList>
		</div>
	</div>
	<!--end::Row--></div>
<!--end::Card body-->
                                        </div>
										<div class="card-footer d-flex justify-content-end py-6 px-9">
												<asp:button ID="btnAdd" runat="server" ValidationGroup="submit" OnClick="btnSave_Click" class="btn btn-light btn-active-light-primary me-2" Text="Save 2"></asp:button>
												<asp:button ID="btnCancel" runat="server" class="btn green-haze btn-circle font-weight-bold mr-2" OnClick="btnCancel_Click" Text="Cancel"></asp:button>
											</div>
                                        <div class="row">
                                            <div class="card-body pt-0">
                                                <table class="table align-middle table-row-dashed fs-6 gy-5" id="kt_ecommerce_sales_table">
                                                    <thead>
                                                        <tr class="text-start text-gray-500 fw-bold fs-7 text-uppercase gs-0">                                                            
                                                            <th class="min-w-50px">TenentID</th>
<th class="min-w-50px">BIN_ID</th>
<th class="min-w-50px">MyComLocID</th>
<th class="min-w-50px">BINDesc1</th>
<th class="min-w-50px">BINDesc2</th>
<th class="min-w-50px">BINRemarks</th>
<th class="min-w-50px">BinReqMaintenace</th>
<th class="min-w-50px">ACTIVE</th>
<th class="min-w-50px">CRUP_ID</th>

															<td>Action</td>
                                                        </tr>
                                                    </thead>
                                                    <tbody class="fw-semibold text-gray-600">
													<asp:ListView ID="Listview1" runat="server" OnItemDataBound="Listview1_ItemDataBound">
                                                            <LayoutTemplate>
											                <tr id="ItemPlaceholder" runat="server">
											                </tr>
										                </LayoutTemplate>
                                                            <ItemTemplate>
                                                                <tr>
												<td> <%# Eval("TenentID")%> </td>
<td> <%# Eval("BIN_ID")%> </td>
<td> <%# Eval("MyComLocID")%> </td>
<td> <%# Eval("BINDesc1")%> </td>
<td> <%# Eval("BINDesc2")%> </td>
<td> <%# Eval("BINRemarks")%> </td>
<td> <%# Eval("BinReqMaintenace")%> </td>
<td> <%# Eval("ACTIVE")%> </td>
<td> <%# Eval("CRUP_ID")%> </td>


												<td class="text-center">
													<div class="d-flex justify-content-end flex-shrink-0">
														<asp:LinkButton ID="btnEdit" CommandName="btnEdit" CommandArgument='<%# Eval("ID")%>' runat="server" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1">
															<i class="ki-duotone ki-pencil fs-2">
																<span class="path1"></span>
																<span class="path2"></span>
															</i>
														</asp:LinkButton>
														<asp:LinkButton ID="btnDelete" CommandName="btnDelete" OnClientClick="return ConfirmMsg();" CommandArgument='<%# Eval("ID")%>' runat="server" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm me-1">
															<i class="ki-duotone ki-trash fs-2">
																<span class="path1"></span>
																<span class="path2"></span>
																<span class="path3"></span>
																<span class="path4"></span>
																<span class="path5"></span>
															</i>															
														</asp:LinkButton>
														<asp:LinkButton ID="LinkButton2" PostBackUrl='<%# "PrintMDSF.aspx?ID="+ Eval("ID")%>' CommandName="btnPrint" CommandArgument='<%# Eval("ID")%>' runat="server" class="btn btn-icon btn-bg-light btn-active-color-primary btn-sm">
															<i class="ki-duotone ki-switch fs-2">
																<span class="path1"></span>
																<span class="path2"></span>
															</i>
														</asp:LinkButton>
													</div>
												</td>  
												     
											</tr>
                                                            </ItemTemplate>
                                                        </asp:ListView>
													
                                                    </tbody>
                                                </table>
                                            </div>
												<asp:HiddenField ID="hideID" runat="server" Value="" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>