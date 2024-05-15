<%@ Page Title="" Language="C#" MasterPageFile="~/NewACMMaster.Master" AutoEventWireup="true" CodeBehind="selectnew.aspx.cs" Inherits="NewAdmin.selectnew" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="app-main flex-column flex-row-fluid" id="kt_app_main">
        <!--begin::Content wrapper-->
        <div class="d-flex flex-column flex-column-fluid">
            <!--begin::Toolbar-->
            <div id="kt_app_toolbar" class="app-toolbar py-3 py-lg-6">
                <!--begin::Toolbar container-->
                <div id="kt_app_toolbar_container" class="app-container container-xxl d-flex flex-stack">
                    <!--begin::Page title-->
                    <div class="page-title d-flex flex-column justify-content-center flex-wrap me-3">
                        <!--begin::Title-->
                        <h1 class="page-heading d-flex text-gray-900 fw-bold fs-3 flex-column justify-content-center my-0">Add Order</h1>
                    </div>
                </div>
                <!--end::Toolbar container-->
            </div>
            <!--end::Toolbar-->
            <!--begin::Content-->
            <div id="kt_app_content" class="app-content flex-column-fluid">
                <div id="kt_app_content_container" class="app-container container-xxl">
                    <div id="kt_ecommerce_edit_order_form" class="form d-flex flex-column flex-lg-row" data-kt-redirect="apps/ecommerce/sales/listing.html">
                        <!--begin::Aside column-->
                        <div class="col-md-12" style="width: 1500px;">
                            <!--begin::Order details-->
                            <div class="card card-flush py-4">
                                <!--begin::Card header-->
                                <div class="card-header">
                                    <div class="card-title">
                                        <h2>Select Table</h2>
                                    </div>
                                </div>
                                <!--end::Card header-->
                                <!--begin::Card body-->
                                <div class="card-body pt-0">
                                    <div class="d-flex flex-column gap-10">

                                        <div class="row">
                                            <div class="col-md-3">
                                                <label class="required form-label">Language</label>
                                                <!--end::Label-->
                                                <!--begin::Select2-->

                                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-select mb-2">
                                                    <asp:ListItem Selected="True" Value="0">--- Select ---</asp:ListItem>
                                                    <asp:ListItem Value="1">English</asp:ListItem>
                                                    <asp:ListItem Value="2">Arabic</asp:ListItem>
                                                    <asp:ListItem Value="3">Hindi</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>
                                            <div class="col-md-3">
                                                <label class="required form-label">Table Name</label>
                                                <asp:DropDownList ID="drpTable" runat="server" AutoPostBack="true" CssClass="form-select mb-2" OnSelectedIndexChanged="drpTable_SelectedIndexChanged">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-3">
                                                <label class="required form-label">Order By</label>
                                                <asp:DropDownList ID="droOrder" runat="server" CssClass="form-select mb-2">
                                                    <asp:ListItem Selected="True" Value="0">--- Select ---</asp:ListItem>
                                                    <asp:ListItem Value="1">Ascending </asp:ListItem>
                                                    <asp:ListItem Value="2">Descending </asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-2">
                                                <label class="required form-label">Order By field</label>
                                                <asp:DropDownList ID="drpBindTopField" runat="server" CssClass="form-select mb-2">
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-1">
                                                <asp:Button ID="btnGetData" runat="server" Text="Generate" CssClass="btn btn-primary" Style="margin-top: 27px;" OnClick="btnGetData_Click" />
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="card-body pt-0">
                                                <table class="table align-middle table-row-dashed fs-6 gy-5" id="kt_ecommerce_sales_table">
                                                    <thead>
                                                        <tr class="text-start text-gray-500 fw-bold fs-7 text-uppercase gs-0">
                                                            <%--  <th class="text-start w-10px pe-2">
                                                                <div class="form-check form-check-sm form-check-custom form-check-solid me-3">
                                                                    <input class="form-check-input" type="checkbox" data-kt-check="true" data-kt-check-target="#kt_ecommerce_sales_table .form-check-input" value="1" />
                                                                </div>
                                                            </th>
                                                            <th class="min-w-100px">Order ID</th>
                                                            <th class="min-w-175px">Customer</th>
                                                            <th class="text-end min-w-70px">Status</th>
                                                            <th class="text-end min-w-100px">Total</th>
                                                            <th class="text-end min-w-100px">Date Added</th>
                                                            <th class="text-end min-w-100px">Date Modified</th>
                                                            <th class="text-end min-w-100px">Actions</th>--%>
                                                            <th>
                                                               <asp:CheckBox ID="checkall" runat="server" class="checkall" AutoPostBack="True" OnCheckedChanged="chkall_CheckedChanged" />
                                                            </th>
                                                            <th>Filed Name</th>
                                                            <th>Data Type</th>
                                                            <th>Allow Null</th>
                                                            <th>Key</th>
                                                            <th>Label Name</th>
                                                            <th>Control Name</th>
                                                            <th>Mendatory</th>
                                                            <th>Validation</th>
                                                            <th>Bind Data with DropDown</th>
                                                            <th>Bind Data with Label</th>
                                                            <th>GridData Display?</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody class="fw-semibold text-gray-600">
                                                        <asp:ListView ID="Listview1" runat="server" OnItemDataBound="Listview1_ItemDataBound">
                                                            <LayoutTemplate>
                                                                <tr id="ItemPlaceholder" runat="server">
                                                                </tr>
                                                            </LayoutTemplate>
                                                            <ItemTemplate>
                                                                <tr role="row" class="odd">
                                                                    <td class="sorting_1">
                                                                         <asp:CheckBox ID="CheckFields" runat="server" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblFieldName" runat="server" Text='<%# Eval("FiedlName") %>'></asp:Label>

                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblDataType" runat="server"></asp:Label>

                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lblIsnullavle" runat="server"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:CheckBox ID="chbKey" Enabled="false" runat="server" value="" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtLabelName" runat="server" class="form-control input-small" Text='<%# RenameFieldname(Eval("FiedlName").ToString().ToUpper()) %>'></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="drpControl" runat="server" CssClass="table-group-action-input form-control input-medium" AutoPostBack="true" OnSelectedIndexChanged="drpControl_SelectedIndexChanged">
                                                                            <asp:ListItem Value="0" Selected="True">-- Select --</asp:ListItem>
                                                                            <asp:ListItem Value="1">TextBox </asp:ListItem>
                                                                            <asp:ListItem Value="2">TextBox with Multiline </asp:ListItem>
                                                                            <asp:ListItem Value="3">TextBox for DateTime </asp:ListItem>
                                                                            <asp:ListItem Value="4">DropDownList</asp:ListItem>
                                                                            <asp:ListItem Value="5">CheckBox</asp:ListItem>

                                                                        </asp:DropDownList>
                                                                    </td>

                                                                    <td class="sorting_1">
                                                                        <asp:CheckBox ID="chMendatory" runat="server" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="drpValidation" runat="server" CssClass="table-group-action-input form-control input-medium">
                                                                            <asp:ListItem Value="0" Selected="True">-- Select --</asp:ListItem>
                                                                            <asp:ListItem Value="1">Numeric Only Validation</asp:ListItem>
                                                                            <asp:ListItem Value="2">Numeric with Dott Validation</asp:ListItem>
                                                                            <asp:ListItem Value="3">Drop Box Validation</asp:ListItem>
                                                                            <asp:ListItem Value="4">Email Validation</asp:ListItem>
                                                                            <asp:ListItem Value="5">Required Validation</asp:ListItem>
                                                                            <asp:ListItem Value="6">DateTime Validation</asp:ListItem>

                                                                        </asp:DropDownList>
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="drpBindData" Enabled="false" runat="server" AutoPostBack="true" CssClass="table-group-action-input form-control input-medium" OnSelectedIndexChanged="drpBindData_SelectedIndexChanged">
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="drpBindField" Enabled="false" runat="server" CssClass="table-group-action-input form-control input-medium">
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                    <td>
                                                                        <asp:CheckBox ID="chGriddata" runat="server" value="" />
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                        </asp:ListView>
                                                    </tbody>
                                                </table>
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
    </div>

</asp:Content>
