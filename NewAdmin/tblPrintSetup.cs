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
    
    public partial class tblPrintSetup
    {
        public int TenentID { get; set; }
        public string Shopid { get; set; }
        public string CashReciptPRinter { get; set; }
        public string CashReceiptFile { get; set; }
        public string CreditInvoicePrinter { get; set; }
        public string CreditInvoiceFile { get; set; }
        public string KitchenNotePrinter { get; set; }
        public string KitchenNoteFile { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
    }
}
