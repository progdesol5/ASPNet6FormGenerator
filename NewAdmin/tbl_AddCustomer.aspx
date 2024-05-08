<%@ Page Title="" Language="C#" MasterPageFile="~/AcmMaster.master" AutoEventWireup="true" CodeBehind="tbl_AddCustomer.aspx.cs" Inherits="NewAdmin.tbl_AddCustomer"  %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="page-content">
        <div class="col-md-12">
            <div class="tabbable-custom tabbable-noborder">
                <ul class="page-breadcrumb breadcrumb">
                    <li>
                        <a href="index.aspx">HOME </a>
                        <i class="fa fa-circle"></i>
                    </li>
                    <li>
                        <a href="#">tbl_AddCustomer</a>
                    </li>
                </ul>
                <asp:Panel ID="pnlSuccessMsg" runat="server" Visible="false">
                    <div class="alert alert-success alert-dismissable">
                        <button aria-hidden="true" data-dismiss="alert" class="close" type="button"></button>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </div>
                </asp:Panel>

                <div class="row py-4">
                    <div class="col-md-12">
                        <div class="form-horizontal form-row-seperated">
                            <div class="portlet light">
                                <div class="portlet-title">
                                    <div class="caption">
                                        <i class="icon-basket font-green-sharp"></i>
                                        <span class="caption-subject font-green-sharp bold uppercase">tbl_AddCustomer</span>
                                    </div>
                                   
                                </div>
                                <div class="portlet-body">

									<!--begin::Form-->
										<form id="kt_project_settings_form" class="form">
											<!--begin::Card body-->
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
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">ID</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtID" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">NAME</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtName" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">DESCRIPTION</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtDescription" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">DELETED</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtDeleted" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">ACTIVATED</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtActivated" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">CREATEDBY</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtCreatedBy" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--><!--begin::Row--><div class="row mb-8">
		<!--bigin::Col-->
		<div class="col-xl-1"></div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-1">
			<div class="fs-6 fw-semibold mt-2 mb-3">CREATEDATE</div>
		</div>
		<!--end::Col-->
		<!--begin::Col-->
		<div class="col-xl-9 fv-row">
			<asp:TextBox style="color:" ID="txtCreateDate" runat="server" class="form-control form-control-solid" name="type" value="" ></asp:TextBox>
		</div>
	</div>
	<!--end::Row--></div>
<!--end::Card body-->
											<!--end::Card body-->
											<!--begin::Card footer-->
											<div class="card-footer d-flex justify-content-end py-6 px-9">
												<div class="btn-group btn-group-circle btn-group-solid">
													<asp:Button ID="btnFirst" class="btn btn-light-danger font-weight-bold mr-2" runat="server" OnClick="btnFirst_Click" Text="First" />
													<asp:Button ID="btnNext" class="btn btn-light-success font-weight-bold mr-2" runat="server" OnClick="btnNext_Click" Text="Next" />
													<asp:Button ID="btnPrev" class="btn btn-light-warning font-weight-bold mr-2" runat="server" OnClick="btnPrev_Click" Text="Prev" />
													<asp:Button ID="btnLast" class="btn btn-light-primary font-weight-bold mr-2" runat="server" Text="Last" OnClick="btnLast_Click" />
												</div>
												<asp:button ID="btnAdd" runat="server" ValidationGroup="submit" OnClick="btnSave_Click" class="btn btn-light btn-active-light-primary me-2" Text="Update"></asp:button>
												<asp:button ID="btnCancel" runat="server" class="btn green-haze btn-circle font-weight-bold mr-2" OnClick="btnCancel_Click" Text="Cancel" ></asp:button>
											</div>
											<!--end::Card footer-->
										</form>
										<!--end:Form-->
                                </div>
                            </div>
                        </div>
						</div>
                    </div>

				<!--begin::Table-->
				<div class="card card-flush mt-6 mt-xl-9">
					<!--begin::Card header-->
					<div class="card-header mt-5">
						<!--begin::Card title-->
						<div class="card-title flex-column">
							<h3 class="fw-bold mb-1">tbl_AddCustomer List</h3>
						</div>
						<!--begin::Card title-->
						<!--begin::Card toolbar-->
						<div class="card-toolbar my-1">
							<!--begin::Select-->
							<div class="me-6 my-1">
								<select id="kt_filter_year" name="year" data-control="select2" data-hide-search="true" class="w-125px form-select form-select-solid form-select-sm">
									<option value="All" selected="selected">Order by ID</option>
									
								</select>
							</div>
							<!--end::Select-->
							<!--begin::Select-->
							<div class="me-4 my-1">
								<select id="kt_filter_orders" name="orders" data-control="select2" data-hide-search="true" class="w-125px form-select form-select-solid form-select-sm">
									<option value="All" selected="selected">Order by Name</option>
									
								</select>
							</div>
							<!--end::Select-->
							<!--begin::Search-->
							<div class="d-flex align-items-center position-relative my-1">
								<i class="ki-duotone ki-magnifier fs-3 position-absolute ms-3">
									<span class="path1"></span>
									<span class="path2"></span>
								</i>
								<input type="text" id="kt_filter_search" class="form-control form-control-solid form-select-sm w-150px ps-9" placeholder="Search Order" />
							</div>
							<!--end::Search-->
						</div>
						<!--begin::Card toolbar-->
					</div>
					<!--end::Card header-->
					<!--begin::Card body-->
					<div class="card-body pt-0">
						<!--begin::Table container-->
						<div class="table-responsive">
							<!--begin::Table-->
							<table id="kt_profile_overview_table" class="table table-row-bordered table-row-dashed gy-4 align-middle fw-bold">
								<thead class="fs-7 text-gray-500 text-uppercase">
									<tr>
										<th class="min-w-50px">ID</th>

<th class="min-w-50px">Name</th>

<th class="min-w-50px">Description</th>

<th class="min-w-50px">Deleted</th>

<th class="min-w-50px">Activated</th>

<th class="min-w-50px">CreatedBy</th>

<th class="min-w-50px">CreateDate</th>

										<td>Action</td>
									</tr>
								</thead>
								<tbody class="fs-6">
									<asp:ListView ID="Listview1" runat="server" OnItemCommand="ListProduct_ItemCommand" DataKey="ID" DataKeyNames="ID">
										<LayoutTemplate>
											<tr id="ItemPlaceholder" runat="server">
											</tr>
										</LayoutTemplate>
										<ItemTemplate>
											<tr>
												<td> <%# Eval("ID")%> </td>

<td> <%# Eval("Name")%> </td>

<td> <%# Eval("Description")%> </td>

<td> <%# Eval("Deleted")%> </td>

<td> <%# Eval("Activated")%> </td>

<td> <%# Eval("CreatedBy")%> </td>

<td> <%# Eval("CreateDate")%> </td>


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
							<!--end::Table-->
						</div>
						<!--end::Table container-->
						<asp:HiddenField ID="hideID" runat="server" Value="" />
					</div>
					<!--end::Card body-->
				</div>
				<!--end::Card-->

   
			</div>
		</div>
	</div>			
</asp:Content>