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
    
    public partial class HRMS_Rec_FilterHD
    {
        public HRMS_Rec_FilterHD()
        {
            this.HRMS_Rec_FilterDT = new HashSet<HRMS_Rec_FilterDT>();
        }
    
        public int FilterID { get; set; }
        public string FilterType { get; set; }
        public string FilterMode { get; set; }
        public Nullable<bool> Deletedby { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual ICollection<HRMS_Rec_FilterDT> HRMS_Rec_FilterDT { get; set; }
    }
}
