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
    
    public partial class Campaign_MasterProdCat
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int CampaignID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> MySerialNumber { get; set; }
        public Nullable<int> CatID { get; set; }
        public Nullable<int> QtyAllotted { get; set; }
        public Nullable<int> QtyConsumed { get; set; }
        public Nullable<int> AmtAllotted { get; set; }
        public Nullable<int> AmtConsumed { get; set; }
        public Nullable<bool> CActive { get; set; }
        public Nullable<bool> CDelete { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Petcentage { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public Nullable<System.DateTime> Syncby { get; set; }
        public Nullable<int> SyncId { get; set; }
    }
}
