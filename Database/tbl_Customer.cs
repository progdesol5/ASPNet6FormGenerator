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
    
    public partial class tbl_Customer
    {
        public int Id { get; set; }
        public int TenentID { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string AlternateNumber { get; set; }
        public string EmailId { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaciNumber { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> DefaultAddress { get; set; }
    }
}
