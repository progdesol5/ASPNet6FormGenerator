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
    
    public partial class tbl_QuestionTag
    {
        public int TenentID { get; set; }
        public int LocationId { get; set; }
        public int BranchId { get; set; }
        public int ID { get; set; }
        public string TagName { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<long> CruipID { get; set; }
    }
}