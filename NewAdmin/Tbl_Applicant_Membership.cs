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
    
    public partial class Tbl_Applicant_Membership
    {
        public int AppID { get; set; }
        public int MemberId { get; set; }
        public int LocationId { get; set; }
        public string MemberName { get; set; }
        public Nullable<int> MemberRole { get; set; }
        public Nullable<System.DateTime> MemberMonth { get; set; }
        public Nullable<System.DateTime> MemberYear { get; set; }
        public Nullable<bool> Activebit { get; set; }
        public Nullable<bool> DeletedBy { get; set; }
        public Nullable<int> ResumeID { get; set; }
        public string Status { get; set; }
    }
}
