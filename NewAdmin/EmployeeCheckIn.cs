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
    
    public partial class EmployeeCheckIn
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int EmployeeID { get; set; }
        public int CheckInID { get; set; }
        public string GoogleName { get; set; }
        public string Latitute { get; set; }
        public string Longitute { get; set; }
        public Nullable<decimal> MeterDistAllowed { get; set; }
        public string STATE { get; set; }
        public string CITY { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public string Block { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Lane { get; set; }
        public string ForFlat { get; set; }
        public string REMARKS { get; set; }
        public Nullable<bool> AutoApprove { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Switch1 { get; set; }
        public string Switch2 { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> CompID { get; set; }
    }
}
