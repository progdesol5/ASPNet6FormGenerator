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
    
    public partial class POSTermSetup
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int TerminalID { get; set; }
        public Nullable<int> RefID { get; set; }
        public string RefType { get; set; }
        public string RefSubtype { get; set; }
        public string Period_code { get; set; }
        public string MYSYSNAME { get; set; }
        public string mysys { get; set; }
        public string GLPOST { get; set; }
        public string GLPOST1 { get; set; }
        public string GLPOSTREF { get; set; }
        public string GLPOSTREF1 { get; set; }
        public string ICPOST { get; set; }
        public string ICPOSTREF { get; set; }
        public string TranType { get; set; }
        public string Transsubtype { get; set; }
        public Nullable<int> transid { get; set; }
        public Nullable<int> transsubid { get; set; }
        public Nullable<int> CounterID { get; set; }
        public string CounterName { get; set; }
        public Nullable<int> BIN_ID { get; set; }
        public string BIN_TYPE { get; set; }
        public string GRNREF { get; set; }
        public Nullable<decimal> DISPER { get; set; }
        public Nullable<decimal> DISAMT { get; set; }
        public Nullable<decimal> TAXAMT { get; set; }
        public Nullable<decimal> TAXPER { get; set; }
        public Nullable<decimal> PROMOTIONAMT { get; set; }
        public string Stutas { get; set; }
        public string ExtraField1 { get; set; }
        public string ExtraField2 { get; set; }
        public string ExtraSwitch1 { get; set; }
        public Nullable<int> TransDocNo { get; set; }
        public Nullable<int> LinkTransID { get; set; }
        public string invoice_Source { get; set; }
        public string Payment_Details { get; set; }
        public Nullable<bool> AllowminusQTY { get; set; }
    }
}