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
    
    public partial class Accounts_Voucher
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int VoucherID { get; set; }
        public string VoucherCode { get; set; }
        public Nullable<int> FPeriod_ID { get; set; }
        public int VoucherType_ID { get; set; }
        public Nullable<int> Account_ID { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public string Narrations { get; set; }
        public string ReceiverName { get; set; }
        public string ReferenceNo { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
