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
    
    public partial class tbl_emp_leave
    {
        public int EMPLeaveID { get; set; }
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<int> DeptID { get; set; }
        public Nullable<int> LeaveType { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> Todate { get; set; }
        public string EmergencyNODuringLeave { get; set; }
        public string AddressDuringLeave { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> deleted { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
