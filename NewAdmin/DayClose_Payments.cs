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
    
    public partial class DayClose_Payments
    {
        public int PaymentID { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> ShiftID { get; set; }
        public string CloseDate { get; set; }
        public string PaymentType { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public Nullable<decimal> Cashonhand { get; set; }
        public Nullable<decimal> ClosingBalance { get; set; }
        public string Comments { get; set; }
    }
}
