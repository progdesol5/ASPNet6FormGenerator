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
    
    public partial class tbl_TarriefZone
    {
        public int Id { get; set; }
        public int TenentID { get; set; }
        public int LocationId { get; set; }
        public int TransType { get; set; }
        public int ServiceType { get; set; }
        public int Carier { get; set; }
        public int COUNTRYID { get; set; }
        public string Zone { get; set; }
        public string CountryName { get; set; }
        public string switch1 { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}