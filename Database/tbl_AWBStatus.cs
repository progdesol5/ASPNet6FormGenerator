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
    
    public partial class tbl_AWBStatus
    {
        public int TenentID { get; set; }
        public int AWBType { get; set; }
        public string AWBSubType { get; set; }
        public int UniqueID { get; set; }
        public Nullable<int> RunningSequence { get; set; }
        public Nullable<int> SeqNo { get; set; }
        public Nullable<int> NextStatusID { get; set; }
        public Nullable<int> Category { get; set; }
        public Nullable<int> SubCategory { get; set; }
        public string ScanCode { get; set; }
        public string StatusEnglish { get; set; }
        public string StatusArabic { get; set; }
        public string StatusOther { get; set; }
        public Nullable<int> AWStatusTracking { get; set; }
        public Nullable<int> AWStatusProgrammer { get; set; }
        public int Department1 { get; set; }
        public Nullable<int> Department2 { get; set; }
        public Nullable<int> Department3 { get; set; }
        public Nullable<int> Department4 { get; set; }
        public Nullable<int> Department5 { get; set; }
        public Nullable<int> Role1 { get; set; }
        public Nullable<int> Role2 { get; set; }
        public Nullable<int> Role3 { get; set; }
        public Nullable<int> Role4 { get; set; }
        public Nullable<int> Role5 { get; set; }
        public string RemarksNotes { get; set; }
        public string SWITCH1 { get; set; }
        public string SWITCH2 { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public string syncStatus { get; set; }
    }
}