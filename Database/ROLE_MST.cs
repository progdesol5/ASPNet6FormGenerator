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
    
    public partial class ROLE_MST
    {
        public int TenentID { get; set; }
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_NAME1 { get; set; }
        public string ROLE_NAME2 { get; set; }
        public string ROLE_DESC { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public System.DateTime ACTIVE_FROM_DT { get; set; }
        public System.DateTime ACTIVE_TO_DT { get; set; }
        public Nullable<int> ERP_TENANT_ID { get; set; }
        public long CRUP_ID { get; set; }
        public Nullable<bool> ACTIVEROLE { get; set; }
        public Nullable<System.DateTime> ROLLDATE { get; set; }
    }
}
