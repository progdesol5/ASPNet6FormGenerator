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
    
    public partial class tbl_Course_initiate
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int CourseID { get; set; }
        public string CourseUserRef { get; set; }
        public int CourseManagementNo { get; set; }
        public int MYID { get; set; }
        public string Version { get; set; }
        public Nullable<int> coordinatoremp_id { get; set; }
        public Nullable<System.DateTime> DateInitiated { get; set; }
        public Nullable<int> InitiatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<int> CourseStatus { get; set; }
        public int TenderID { get; set; }
        public Nullable<int> CruipID { get; set; }
    }
}
