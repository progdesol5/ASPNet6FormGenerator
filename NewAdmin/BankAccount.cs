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
    
    public partial class BankAccount
    {
        public int TenentID { get; set; }
        public int BankID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string BankAccountName { get; set; }
        public string BankDetails { get; set; }
        public string AccountNo { get; set; }
        public string ContactPerson { get; set; }
        public string Phonenumber { get; set; }
        public string InternetBanking { get; set; }
        public Nullable<bool> Store { get; set; }
        public string Status { get; set; }
        public string bankorder { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> deleted { get; set; }
    }
}