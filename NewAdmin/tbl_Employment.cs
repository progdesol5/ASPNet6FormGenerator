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
    
    public partial class tbl_Employment
    {
        public int EmployementID { get; set; }
        public int TenentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> JobTitleID { get; set; }
        public string OfficeType { get; set; }
        public Nullable<decimal> MonthlySalary { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string IBANNumber { get; set; }
        public string JobDesc1 { get; set; }
        public string jobDesc2 { get; set; }
        public string jobDesc3 { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.DateTime> datetime { get; set; }
        public Nullable<int> crupid { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}
