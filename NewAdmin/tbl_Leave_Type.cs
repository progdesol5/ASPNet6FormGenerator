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
    
    public partial class tbl_Leave_Type
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int BranchId { get; set; }
        public int LeavID { get; set; }
        public string LeaveName1 { get; set; }
        public string LeaveName2 { get; set; }
        public string LeaveName3 { get; set; }
        public Nullable<bool> OnLeaveApply { get; set; }
        public Nullable<bool> SickLeaveApply { get; set; }
        public Nullable<bool> LWPApply { get; set; }
        public Nullable<bool> IndeminityApply { get; set; }
        public Nullable<bool> NationalHolidayApply { get; set; }
        public Nullable<bool> WeekEndApply { get; set; }
        public Nullable<bool> RestApply { get; set; }
        public Nullable<bool> DuringPenaltyApply { get; set; }
        public Nullable<bool> OnOvertimeApply { get; set; }
        public string exclude_in_reports_if_no_entitlement { get; set; }
        public Nullable<int> operational_country_id { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<long> CruipID { get; set; }
    }
}
