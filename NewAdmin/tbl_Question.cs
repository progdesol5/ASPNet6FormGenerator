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
    
    public partial class tbl_Question
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int BranchId { get; set; }
        public int QuestionID { get; set; }
        public Nullable<int> AppID { get; set; }
        public string QuestionName { get; set; }
        public string DisplayText { get; set; }
        public string AnswerFormat { get; set; }
        public Nullable<bool> IncludeAllQuestion { get; set; }
        public Nullable<int> QuestionTag { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<long> CruipID { get; set; }
    }
}
