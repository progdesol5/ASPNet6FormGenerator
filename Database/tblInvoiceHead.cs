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
    
    public partial class tblInvoiceHead
    {
        public int InvoiceKey { get; set; }
        public int AirwayBillKey { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> TotalGrossWeight { get; set; }
        public Nullable<decimal> TotalNetWeight { get; set; }
        public Nullable<int> NumberOfPallets { get; set; }
        public Nullable<decimal> GrossAmount { get; set; }
        public Nullable<decimal> OtherChg1 { get; set; }
        public Nullable<decimal> OtherChg2 { get; set; }
        public Nullable<decimal> OtherChg3 { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public string Carrier { get; set; }
        public string OwnShipmentRefNo { get; set; }
        public string PackageMarks { get; set; }
        public string EeceiverReferenceNo { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int CompanyID { get; set; }
        public int ID { get; set; }
    }
}
