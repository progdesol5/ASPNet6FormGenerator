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
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> StartDt { get; set; }
        public Nullable<System.DateTime> EndDt { get; set; }
        public string Color { get; set; }
        public string url { get; set; }
        public Nullable<int> Createby { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string CRMReference { get; set; }
        public Nullable<int> MyID { get; set; }
        public Nullable<int> MySerial { get; set; }
        public string TransactionStatus { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> ActionType { get; set; }
        public string FromAppoint { get; set; }
        public string ToAppoint { get; set; }
        public Nullable<System.DateTime> ExpStartDate { get; set; }
        public Nullable<System.DateTime> ExpEndDate { get; set; }
        public string Employee { get; set; }
        public Nullable<int> Emp_ID { get; set; }
        public string customer { get; set; }
        public string status { get; set; }
        public Nullable<bool> JobDone { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public Nullable<int> C_ID { get; set; }
        public string Remark { get; set; }
        public string Prefix { get; set; }
    }
}