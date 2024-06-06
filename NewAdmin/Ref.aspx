<%@ Page Title="" Language="C#" MasterPageFile="~/ACM.Master" AutoEventWireup="true" CodeBehind="Ref.aspx.cs" Inherits="NewAdmin.Ref" %>

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
                        <h1 class="page-heading d-flex text-gray-900 fw-bold fs-3 flex-column justify-content-center my-0">Ref Table</h1>

                    </div>

                </div>
                <!--end::Toolbar container-->
            </div>
            <!--end::Toolbar-->
            <!--begin::Content-->
            <div id="kt_app_content" class="app-content flex-column-fluid">
                <!--begin::Content container-->
                <div id="kt_app_content_container" class="app-container container-xxl">
                    <!--begin::Card-->
                    <div class="card">
                        <!--begin::Card header-->
                        <div class="card-header border-0 pt-6">
                            <!--begin::Card title-->
                            <div class="card-title">
                                <!--begin::Search-->
                              
                                <div class="row">
                                    <div class="col-md-4">
                                        <label class="required form-label">Tenent ID</label>
                                        <asp:DropDownList ID="drptenent" runat="server" CssClass="form-select mb-2" AutoPostBack="true" OnSelectedIndexChanged="drptenent_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-6">
                                        <label class="required form-label">Ref Type</label>
                                        <asp:DropDownList ID="drpreftype" runat="server" CssClass="form-select mb-2"></asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:Button ID="btnsearch" runat="server" Text="Search" CssClass="btn btn-primary" Style="margin-top: 27px;" OnClick="btnsearch_Click" />
                                    </div>
                                </div>

                                <!--end::Search-->
                            </div>
                            <!--begin::Card title-->
                            <!--begin::Card toolbar-->
                            <div class="card-toolbar">
                            </div>
                            <!--end::Card toolbar-->
                        </div>
                        <!--end::Card header-->
                        <!--begin::Card body-->
                        <div class="card-body pt-0">
                            <!--begin::Table-->
                            <table class="table align-middle table-row-dashed fs-6 gy-5" id="kt_customers_table">
                                <thead>
                                    <tr class="text-start text-gray-500 fw-bold fs-7 text-uppercase gs-0">

                                        <th class="min-w-125px">Tenent ID</th>
                                        <th class="min-w-125px">Ref Type</th>
                                        <th class="min-w-125px">Ref SubType</th>
                                        <th class="min-w-125px">Add New Refname</th>
                                    </tr>
                                </thead>
                                <tbody class="fw-semibold text-gray-600">
                                    <asp:ListView ID="listreftable" runat="server">
                                        <LayoutTemplate>
                                            <tr id="ItemPlaceholder" runat="server">
                                            </tr>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    <%# Eval("TenentID") %>
                                                </td>
                                                <td>
                                                    <%# Eval("REFTYPE") %>
                                                </td>
                                                <td>
                                                    <%# Eval("REFSUBTYPE") %>
                                                </td>
                                                <td>
                                                     <a class="btn btn-primary" style="padding: 6px;" href="addnewrefname.aspx?TenentID=<%# Eval("TenentID") %>&reftype=<%# Eval("REFTYPE") %>&refsubtype=<%# Eval("REFSUBTYPE") %>">RefName</a>
                                                    <%--<asp:Button ID="btnedit" runat="server" Text="RefName" CssClass="btn btn-primary" Style="padding: 6px;" />--%>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </tbody>
                            </table>
                            <!--end::Table-->
                        </div>
                        <!--end::Card body-->
                    </div>

                </div>
                <!--end::Content container-->
            </div>
            <!--end::Content-->
        </div>
        <!--end::Content wrapper-->
        <!--begin::Footer-->
        <div id="kt_app_footer" class="app-footer">
            <!--begin::Footer container-->
            <div class="app-container container-fluid d-flex flex-column flex-md-row flex-center flex-md-stack py-3">
                <!--begin::Copyright-->
                <div class="text-gray-900 order-2 order-md-1">
                    <span class="text-muted fw-semibold me-1">2024&copy;</span>
                    <a href="https://keenthemes.com" target="_blank" class="text-gray-800 text-hover-primary">Keenthemes</a>
                </div>
                <!--end::Copyright-->
                <!--begin::Menu-->
                <ul class="menu menu-gray-600 menu-hover-primary fw-semibold order-1">
                    <li class="menu-item">
                        <a href="https://keenthemes.com" target="_blank" class="menu-link px-2">About</a>
                    </li>
                    <li class="menu-item">
                        <a href="https://devs.keenthemes.com" target="_blank" class="menu-link px-2">Support</a>
                    </li>
                    <li class="menu-item">
                        <a href="https://1.envato.market/EA4JP" target="_blank" class="menu-link px-2">Purchase</a>
                    </li>
                </ul>
                <!--end::Menu-->
            </div>
            <!--end::Footer container-->
        </div>
        <!--end::Footer-->
    </div>
</asp:Content>
