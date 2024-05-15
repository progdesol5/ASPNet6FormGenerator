//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Cashier
    {
        public int ShiftNumber { get; set; }
        public int TenentID { get; set; }
        public int SystemID { get; set; }
        public int EmployeeID { get; set; }
        public string Day { get; set; }
        public System.DateTime Date { get; set; }
        public string Shift { get; set; }
        public string TotalPayment { get; set; }
        public Nullable<int> OpeningChequeCount { get; set; }
        public Nullable<decimal> OpeningChequeAmount { get; set; }
        public Nullable<decimal> OpeningCashAmount { get; set; }
        public Nullable<decimal> EarlierShiftCashAmount { get; set; }
        public Nullable<int> ClosingChequeCount { get; set; }
        public Nullable<decimal> ClosingChequeAmount { get; set; }
        public Nullable<decimal> ClosingCashAmountPendingofCurrentShift { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CashCollectedBy { get; set; }
        public Nullable<decimal> CashAmountCollectedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
