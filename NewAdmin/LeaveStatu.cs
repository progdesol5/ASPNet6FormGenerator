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
    
    public partial class LeaveStatu
    {
        public LeaveStatu()
        {
            this.LeaveRequests = new HashSet<LeaveRequest>();
        }
    
        public int ID { get; set; }
        public Nullable<int> TelentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LeaveStatusText { get; set; }
    
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
