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
    
    public partial class tbl_Performance_Review
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int BranchId { get; set; }
        public int ID { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> reviewer_id { get; set; }
        public Nullable<int> creator_id { get; set; }
        public Nullable<int> job_title_code { get; set; }
        public Nullable<int> sub_division_id { get; set; }
        public Nullable<System.DateTime> creation_date { get; set; }
        public Nullable<System.DateTime> period_from { get; set; }
        public Nullable<System.DateTime> period_to { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<int> state { get; set; }
        public string kpis { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<long> CruipID { get; set; }
    }
}
