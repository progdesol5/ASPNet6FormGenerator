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
    
    public partial class Complaint_Subscription
    {
        public int SubscriptionID { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string SubscriptionName { get; set; }
        public Nullable<bool> IsProduct { get; set; }
        public Nullable<bool> IsParts { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}