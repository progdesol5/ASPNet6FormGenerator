﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourierDB2023Entities1 : DbContext
    {
        public CourierDB2023Entities1()
            : base("name=CourierDB2023Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACMManageBanner> ACMManageBanners { get; set; }
        public DbSet<ACTIVITYRIGHT> ACTIVITYRIGHTS { get; set; }
        public DbSet<city> cities { get; set; }
        public DbSet<country> countries { get; set; }
        public DbSet<CRMUserSetup> CRMUserSetups { get; set; }
        public DbSet<CRUP_MST> CRUP_MST { get; set; }
        public DbSet<CRUPAudit> CRUPAudits { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<FUNCTION_MST> FUNCTION_MST { get; set; }
        public DbSet<ICTR_DT> ICTR_DT { get; set; }
        public DbSet<ICTR_DT_Sales> ICTR_DT_Sales { get; set; }
        public DbSet<ICTR_HD> ICTR_HD { get; set; }
        public DbSet<ICTR_HD_Sales> ICTR_HD_Sales { get; set; }
        public DbSet<ICTR_HD_Sales_tmp> ICTR_HD_Sales_tmp { get; set; }
        public DbSet<ICTR_sales_payment> ICTR_sales_payment { get; set; }
        public DbSet<ICTRPayTerms_HD> ICTRPayTerms_HD { get; set; }
        public DbSet<ICUOM> ICUOMs { get; set; }
        public DbSet<MODULE_MAP> MODULE_MAP { get; set; }
        public DbSet<MODULE_MST> MODULE_MST { get; set; }
        public DbSet<PRIVILAGE_MENUDemon> PRIVILAGE_MENUDemon { get; set; }
        public DbSet<PRIVILEGE_MST> PRIVILEGE_MST { get; set; }
        public DbSet<RefLabelMST> RefLabelMSTs { get; set; }
        public DbSet<REFTABLE> REFTABLEs { get; set; }
        public DbSet<RefTableAdmin> RefTableAdmins { get; set; }
        public DbSet<ROLE_MST> ROLE_MST { get; set; }
        public DbSet<RoleActivity> RoleActivities { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }
        public DbSet<tbl_AirWayBill> tbl_AirWayBill { get; set; }
        public DbSet<tbl_AirWayBill_Temp> tbl_AirWayBill_Temp { get; set; }
        public DbSet<tbl_AirWayBillLog> tbl_AirWayBillLog { get; set; }
        public DbSet<tbl_Awb_ConsolidationGrp> tbl_Awb_ConsolidationGrp { get; set; }
        public DbSet<tbl_AWB_ConsolidationMst> tbl_AWB_ConsolidationMst { get; set; }
        public DbSet<tbl_AWBDriverDRS> tbl_AWBDriverDRS { get; set; }
        public DbSet<tbl_AWBShipItems> tbl_AWBShipItems { get; set; }
        public DbSet<tbl_AWBStatus> tbl_AWBStatus { get; set; }
        public DbSet<tbl_Cashier> tbl_Cashier { get; set; }
        public DbSet<tbl_CashierProcess> tbl_CashierProcess { get; set; }
        public DbSet<tbl_Currency_Type> tbl_Currency_Type { get; set; }
        public DbSet<tbl_Customer> tbl_Customer { get; set; }
        public DbSet<TBL_CUSTOMERDELIVERY_DTL> TBL_CUSTOMERDELIVERY_DTL { get; set; }
        public DbSet<tbl_Delivery> tbl_Delivery { get; set; }
        public DbSet<tbl_Employee> tbl_Employee { get; set; }
        public DbSet<tbl_Financial> tbl_Financial { get; set; }
        public DbSet<tbl_Group> tbl_Group { get; set; }
        public DbSet<tbl_GroupMenu> tbl_GroupMenu { get; set; }
        public DbSet<tbl_Menu> tbl_Menu { get; set; }
        public DbSet<tbl_TarriefLocalRates> tbl_TarriefLocalRates { get; set; }
        public DbSet<tbl_TarriefRates> tbl_TarriefRates { get; set; }
        public DbSet<tbl_TarriefZone> tbl_TarriefZone { get; set; }
        public DbSet<tbl_UserRule> tbl_UserRule { get; set; }
        public DbSet<tblActSLSetup> tblActSLSetups { get; set; }
        public DbSet<tblAirWayMain> tblAirWayMains { get; set; }
        public DbSet<tblAirWayMain2Packing> tblAirWayMain2Packing { get; set; }
        public DbSet<tblCashier> tblCashiers { get; set; }
        public DbSet<tblCategoryMaster> tblCategoryMasters { get; set; }
        public DbSet<tblCityStatesCounty> tblCityStatesCounties { get; set; }
        public DbSet<tblCompanyMaster> tblCompanyMasters { get; set; }
        public DbSet<TBLCOMPANYSETUP> TBLCOMPANYSETUPs { get; set; }
        public DbSet<TBLCONTACT_DEL_ADRES> TBLCONTACT_DEL_ADRES { get; set; }
        public DbSet<tblContract_driver> tblContract_driver { get; set; }
        public DbSet<tblCOUNTRY> tblCOUNTRies { get; set; }
        public DbSet<tblCustomerAddress> tblCustomerAddresses { get; set; }
        public DbSet<tblDistrictStatesCounty> tblDistrictStatesCounties { get; set; }
        public DbSet<tblDriverAreaBlock> tblDriverAreaBlocks { get; set; }
        public DbSet<tblDriverDeliverystatu> tblDriverDeliverystatus { get; set; }
        public DbSet<tblInvoiceDetail> tblInvoiceDetails { get; set; }
        public DbSet<tblInvoiceHead> tblInvoiceHeads { get; set; }
        public DbSet<TBLLabelDTL> TBLLabelDTLs { get; set; }
        public DbSet<TBLLabelMST> TBLLabelMSTs { get; set; }
        public DbSet<tblLanguage> tblLanguages { get; set; }
        public DbSet<TBLLOCATION> TBLLOCATIONs { get; set; }
        public DbSet<TBLMaintanance> TBLMaintanances { get; set; }
        public DbSet<tblMenuMaster> tblMenuMasters { get; set; }
        public DbSet<tblPrintSetup> tblPrintSetups { get; set; }
        public DbSet<tblRef> tblRefs { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tbltranssubtype> tbltranssubtypes { get; set; }
        public DbSet<tbltranstype> tbltranstypes { get; set; }
        public DbSet<tblUserMaster> tblUserMasters { get; set; }
        public DbSet<tblUserPermission> tblUserPermissions { get; set; }
        public DbSet<tblZipCodeDistrictStatesCounty> tblZipCodeDistrictStatesCounties { get; set; }
        public DbSet<TemplateMaster> TemplateMasters { get; set; }
        public DbSet<tempUser1> tempUser1 { get; set; }
        public DbSet<TreeFunction> TreeFunctions { get; set; }
        public DbSet<TreeNode> TreeNodes { get; set; }
        public DbSet<USER_DTL> USER_DTL { get; set; }
        public DbSet<USER_MST> USER_MST { get; set; }
        public DbSet<User_Product_Add> User_Product_Add { get; set; }
        public DbSet<USER_RIGHTS> USER_RIGHTS { get; set; }
        public DbSet<USER_ROLE> USER_ROLE { get; set; }
        public DbSet<tbl_AccountType> tbl_AccountType { get; set; }
        public DbSet<tbl_Driver> tbl_Driver { get; set; }
        public DbSet<tbl_Employeetest> tbl_Employeetest { get; set; }
        public DbSet<tbl_ShipmentItems> tbl_ShipmentItems { get; set; }
        public DbSet<tbl_UserLogin> tbl_UserLogin { get; set; }
        public DbSet<tbl_Vendor> tbl_Vendor { get; set; }
        public DbSet<tbl_Window> tbl_Window { get; set; }
        public DbSet<tblBlankRow> tblBlankRows { get; set; }
        public DbSet<tblCourierImport> tblCourierImports { get; set; }
        public DbSet<tblCourierImport_Temp> tblCourierImport_Temp { get; set; }
        public DbSet<tblRefModule> tblRefModules { get; set; }
        public DbSet<testing> testings { get; set; }
        public DbSet<CountStatDistCity> CountStatDistCities { get; set; }
        public DbSet<View_CustomerListCountryCityState> View_CustomerListCountryCityState { get; set; }
        public DbSet<ViewCountryStateCity> ViewCountryStateCities { get; set; }
        public DbSet<vmSenderReceiver> vmSenderReceivers { get; set; }
        public DbSet<vmSenderReceiverNew> vmSenderReceiverNews { get; set; }
        public DbSet<VwAWStatusCatWise> VwAWStatusCatWises { get; set; }
    }
}
