//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEPTOFSale
    {
        public int TenentID { get; set; }
        public int SalDeptID { get; set; }
        public string DeptDesc1 { get; set; }
        public string DeptDesc2 { get; set; }
        public string DeptDesc3 { get; set; }
        public string DeptRemarks { get; set; }
        public string SalesAccountID { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public string ExpenseAccountID { get; set; }
        public string PurchaseAccountID { get; set; }
        public Nullable<bool> Active_Flag { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<int> DeptManagerID { get; set; }
    }
}
