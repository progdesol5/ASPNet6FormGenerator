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
    
    public partial class Tbl_Event_Register
    {
        public int TenantID { get; set; }
        public int EventID { get; set; }
        public int MyID { get; set; }
        public int ContactMyID { get; set; }
        public string Attendee { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> positionId { get; set; }
        public string PositionName { get; set; }
        public string MobileNo { get; set; }
        public string Busphone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> RegisteredAs { get; set; }
        public string RegistrationID { get; set; }
        public Nullable<int> MyTransID { get; set; }
        public Nullable<int> PaidBy { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public string PaymentReference { get; set; }
        public Nullable<int> PaymentTermsId { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> AttendedTime { get; set; }
        public string BatchPrintedBy { get; set; }
        public Nullable<System.DateTime> BatchPrintedDateTime { get; set; }
        public string CertPrintedBy { get; set; }
        public Nullable<System.DateTime> CertPrintedDateTime { get; set; }
        public Nullable<System.DateTime> RegisteredDate { get; set; }
        public string RegisteredBy { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ContactId { get; set; }
        public string IMG { get; set; }
        public string BARCODE { get; set; }
    }
}
