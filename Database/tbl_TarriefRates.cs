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
    
    public partial class tbl_TarriefRates
    {
        public int Id { get; set; }
        public int TenentID { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> ContentType { get; set; }
        public string RateFor { get; set; }
        public int AWBTYPE { get; set; }
        public int ServiceType { get; set; }
        public decimal FromRange { get; set; }
        public decimal ToRange { get; set; }
        public string Zone { get; set; }
        public Nullable<decimal> RateAmount { get; set; }
        public Nullable<decimal> FuelCharge { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}
