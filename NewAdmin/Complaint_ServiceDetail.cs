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
    
    public partial class Complaint_ServiceDetail
    {
        public int SubID { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> ServicesID { get; set; }
        public Nullable<int> SubscriptionID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Totaldurration { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Serial { get; set; }
        public string Warranty { get; set; }
        public Nullable<bool> Isactive { get; set; }
    }
}
