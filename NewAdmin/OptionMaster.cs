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
    
    public partial class OptionMaster
    {
        public OptionMaster()
        {
            this.RowMasters = new HashSet<RowMaster>();
        }
    
        public int ID { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> QuestionID { get; set; }
        public string OptionName { get; set; }
        public string SubOption { get; set; }
        public Nullable<bool> Answer { get; set; }
        public string AnswerText { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
    
        public virtual ICollection<RowMaster> RowMasters { get; set; }
    }
}
