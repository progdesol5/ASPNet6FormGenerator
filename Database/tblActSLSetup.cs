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
    
    public partial class tblActSLSetup
    {
        public int TenentID { get; set; }
        public int locationID { get; set; }
        public int transid { get; set; }
        public int transsubid { get; set; }
        public Nullable<int> module { get; set; }
        public Nullable<int> DeliveryLocation { get; set; }
        public Nullable<int> CompniID { get; set; }
        public Nullable<int> LastClosePeriod { get; set; }
        public Nullable<int> CurrentPeriod { get; set; }
        public Nullable<int> PaymentDays { get; set; }
        public Nullable<int> ReminderDays { get; set; }
        public Nullable<int> AcceptWarantee { get; set; }
        public Nullable<bool> DescWithWarantee { get; set; }
        public Nullable<bool> DescWithSerial { get; set; }
        public Nullable<bool> DescWithColor { get; set; }
        public Nullable<bool> AllowMinusQty { get; set; }
        public string HeaderLine { get; set; }
        public string TagLine { get; set; }
        public string BottomTagLine { get; set; }
        public string PaymentDetails { get; set; }
        public string TCQuotation { get; set; }
        public string IntroLetter { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public Nullable<int> SalesAdminID { get; set; }
    }
}
