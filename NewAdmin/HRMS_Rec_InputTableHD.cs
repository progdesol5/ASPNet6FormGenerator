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
    
    public partial class HRMS_Rec_InputTableHD
    {
        public HRMS_Rec_InputTableHD()
        {
            this.HRMS_Rec_FilterDT = new HashSet<HRMS_Rec_FilterDT>();
            this.HRMS_Rec_InputTaleDT = new HashSet<HRMS_Rec_InputTaleDT>();
            this.HRMS_Rec_OutputTableDT = new HashSet<HRMS_Rec_OutputTableDT>();
        }
    
        public long SortNo { get; set; }
        public string MainCategory { get; set; }
        public string StartPoint { get; set; }
        public Nullable<bool> NextLineEnd { get; set; }
        public Nullable<bool> DoubleSpacesEnd { get; set; }
        public Nullable<bool> CommaEnd { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<long> NumberOfSubSortAllowed { get; set; }
        public Nullable<bool> Deletedby { get; set; }
        public Nullable<int> Createby { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual ICollection<HRMS_Rec_FilterDT> HRMS_Rec_FilterDT { get; set; }
        public virtual ICollection<HRMS_Rec_InputTaleDT> HRMS_Rec_InputTaleDT { get; set; }
        public virtual ICollection<HRMS_Rec_OutputTableDT> HRMS_Rec_OutputTableDT { get; set; }
    }
}
