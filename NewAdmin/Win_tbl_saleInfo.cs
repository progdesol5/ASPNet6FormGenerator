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
    
    public partial class Win_tbl_saleInfo
    {
        public int TenentID { get; set; }
        public long ID { get; set; }
        public string InvoiceNo { get; set; }
        public string WarehouseNo { get; set; }
        public string Biller { get; set; }
        public string Customer { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> DisRate { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> ShippingFee { get; set; }
        public string SoldBy { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}