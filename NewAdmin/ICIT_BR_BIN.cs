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
    
    public partial class ICIT_BR_BIN
    {
        public int TenentID { get; set; }
        public long MyProdID { get; set; }
        public string period_code { get; set; }
        public string MySysName { get; set; }
        public int Bin_ID { get; set; }
        public int UOM { get; set; }
        public int LocationID { get; set; }
        public Nullable<int> MYTRANSID { get; set; }
        public int OpQty { get; set; }
        public Nullable<int> OnHand { get; set; }
        public Nullable<int> QtyOut { get; set; }
        public Nullable<int> QtyConsumed { get; set; }
        public Nullable<int> QtyReceived { get; set; }
        public Nullable<int> QtyReserved { get; set; }
        public Nullable<int> MinQty { get; set; }
        public Nullable<int> MaxQty { get; set; }
        public Nullable<int> LeadTime { get; set; }
        public string Reference { get; set; }
        public string Active { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
    }
}