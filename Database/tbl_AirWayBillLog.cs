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
    
    public partial class tbl_AirWayBillLog
    {
        public int AWBAccessLogId { get; set; }
        public int TenentID { get; set; }
        public int LocationId { get; set; }
        public long AirwayBillNo { get; set; }
        public int CompID { get; set; }
        public Nullable<int> UniqueID { get; set; }
        public Nullable<int> AccessType { get; set; }
        public string AccessByUser { get; set; }
        public string AccessDateTime { get; set; }
        public string ActionTaken { get; set; }
        public string Switch1 { get; set; }
        public Nullable<int> RunningSequence { get; set; }
        public Nullable<int> AWStatusTracking { get; set; }
        public Nullable<int> AWStatusProgrammer { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public string SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public string syncStatus { get; set; }
    }
}
