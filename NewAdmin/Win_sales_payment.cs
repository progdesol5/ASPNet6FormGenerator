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
    
    public partial class Win_sales_payment
    {
        public int TenentID { get; set; }
        public int ID { get; set; }
        public long sales_id { get; set; }
        public Nullable<int> return_id { get; set; }
        public string payment_type { get; set; }
        public Nullable<decimal> payment_amount { get; set; }
        public Nullable<decimal> change_amount { get; set; }
        public Nullable<decimal> due_amount { get; set; }
        public Nullable<decimal> dis { get; set; }
        public Nullable<decimal> vat { get; set; }
        public string sales_time { get; set; }
        public string c_id { get; set; }
        public string emp_id { get; set; }
        public string Reffrance { get; set; }
        public string comment { get; set; }
        public string TrxType { get; set; }
        public string Shopid { get; set; }
        public Nullable<decimal> ovdisrate { get; set; }
        public Nullable<decimal> vaterate { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public string InvoiceNO { get; set; }
        public string Customer { get; set; }
        public Nullable<decimal> Delivery_Cahrge { get; set; }
        public string PaymentStutas { get; set; }
        public Nullable<int> AmountSplit { get; set; }
    }
}
