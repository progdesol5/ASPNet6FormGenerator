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
    
    public partial class FAChequeBook
    {
        public int TenentID { get; set; }
        public int ChequeID { get; set; }
        public Nullable<int> BankID { get; set; }
        public string ChequeName1 { get; set; }
        public string ChequeName2 { get; set; }
        public string ChequeName3 { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<System.DateTime> Dated { get; set; }
        public Nullable<System.DateTime> DateOutFromBank { get; set; }
        public Nullable<int> COMPID { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> ContactMyID { get; set; }
        public string SWITCH1 { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
    }
}