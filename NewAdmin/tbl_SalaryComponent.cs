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
    
    public partial class tbl_SalaryComponent
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OnlyCTC { get; set; }
        public Nullable<bool> ValueTypeAmount { get; set; }
        public Nullable<bool> ValueTypePercantage { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}