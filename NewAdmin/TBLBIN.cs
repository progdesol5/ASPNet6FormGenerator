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
    
    public partial class TBLBIN
    {
        public int TenentID { get; set; }
        public int BIN_ID { get; set; }
        public Nullable<int> MyComLocID { get; set; }
        public string BINDesc1 { get; set; }
        public string BINDesc2 { get; set; }
        public string BINRemarks { get; set; }
        public Nullable<bool> BinReqMaintenace { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
    }
}