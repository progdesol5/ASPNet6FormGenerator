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
    
    public partial class Voucher
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int VoucherID { get; set; }
        public string VoucherCode { get; set; }
        public int FPeriod_ID { get; set; }
        public int VoucherType_ID { get; set; }
        public Nullable<int> Account_ID { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public bool IsPosted { get; set; }
        public string Narrations { get; set; }
        public string ReceiverName { get; set; }
        public string ReferenceNo { get; set; }
        public Nullable<int> CostCenter_ID { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> crupid { get; set; }
        public string OriginalFileName { get; set; }
        public string FileExtension { get; set; }
        public string FileContentType { get; set; }
        public string FilePath { get; set; }
        public Nullable<bool> IsSingleEntry { get; set; }
        public Nullable<int> Trans_Id { get; set; }
    }
}
