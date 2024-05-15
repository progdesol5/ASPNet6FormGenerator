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
    
    public partial class ICTRPayTerms_HD
    {
        public int TenentID { get; set; }
        public int MyTransID { get; set; }
        public int PaymentTermsId { get; set; }
        public string TransactionTypeIO { get; set; }
        public string CounterID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> CashBankChequeID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string ReferenceNo { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public string Notes { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> CRUP_ID { get; set; }
        public string ApprovalID { get; set; }
        public Nullable<int> AccountantID { get; set; }
        public Nullable<bool> ChequeVerified { get; set; }
        public Nullable<bool> CashVerified { get; set; }
        public Nullable<bool> ATMVerified { get; set; }
        public Nullable<bool> VoucharVerified { get; set; }
        public Nullable<System.DateTime> ChequeVerifiedDate { get; set; }
        public Nullable<System.DateTime> CashVerifiedDate { get; set; }
        public Nullable<System.DateTime> ATMVerifiedDate { get; set; }
        public Nullable<System.DateTime> VoucharVerifiedDate { get; set; }
        public string JVRefNo { get; set; }
        public Nullable<bool> Draft { get; set; }
    }
}
