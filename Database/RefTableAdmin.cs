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
    
    public partial class RefTableAdmin
    {
        public int TenentID { get; set; }
        public int RefAdminId { get; set; }
        public string RefType { get; set; }
        public string RefSubType { get; set; }
        public string MySysName { get; set; }
        public string Descrip { get; set; }
        public string Admin { get; set; }
        public string NormalUser { get; set; }
        public string switch1 { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> StartSerial { get; set; }
        public Nullable<int> EndSerial { get; set; }
        public string Active { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public string Infrastructure { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
    }
}
