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
    
    public partial class TBL_CUSTOMERDELIVERY_DTL
    {
        public int trnid { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> driverid { get; set; }
        public string addrs { get; set; }
        public Nullable<System.DateTime> deliverydt { get; set; }
        public string delimg { get; set; }
        public Nullable<long> pacid { get; set; }
        public string delaction { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public string syncStatus { get; set; }
    }
}
