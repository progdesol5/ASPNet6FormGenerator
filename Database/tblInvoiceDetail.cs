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
    
    public partial class tblInvoiceDetail
    {
        public int InvoiceDetailKey { get; set; }
        public string ItemDescription { get; set; }
        public int ManufactureFrom { get; set; }
        public string CommodityCode { get; set; }
        public int Quantity { get; set; }
        public string QunatityUnit { get; set; }
        public decimal ItemValue { get; set; }
        public string Currencey { get; set; }
        public decimal NetWeight { get; set; }
        public string NetWeightUnit { get; set; }
        public decimal GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public Nullable<int> InvoiceKey { get; set; }
        public Nullable<int> AirwayBillKey { get; set; }
    }
}
