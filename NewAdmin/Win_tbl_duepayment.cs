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
    
    public partial class Win_tbl_duepayment
    {
        public int TenentID { get; set; }
        public long id { get; set; }
        public string receivedate { get; set; }
        public Nullable<long> sales_id { get; set; }
        public Nullable<decimal> totalamt { get; set; }
        public Nullable<decimal> dueamt { get; set; }
        public Nullable<decimal> receiveamt { get; set; }
        public string custid { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}
