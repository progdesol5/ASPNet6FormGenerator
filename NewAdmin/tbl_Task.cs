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
    
    public partial class tbl_Task
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int TaskID { get; set; }
        public int CerticateNo { get; set; }
        public string ActivityId { get; set; }
        public string ProjectId { get; set; }
        public Nullable<int> ForEmp_ID { get; set; }
        public Nullable<int> ReferenceID { get; set; }
        public Nullable<int> PerformingEmp_ID { get; set; }
        public string Subject { get; set; }
        public Nullable<System.DateTime> StartingDate { get; set; }
        public string NoteType { get; set; }
        public string ProjectType { get; set; }
        public string TaskType { get; set; }
        public string TaskStatus { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string Priority { get; set; }
        public Nullable<System.DateTime> ActualCompletionDate { get; set; }
        public Nullable<int> CompletedPerctange { get; set; }
        public Nullable<System.DateTime> ReminderDate { get; set; }
        public Nullable<System.DateTime> ReminderTime { get; set; }
        public string Categories { get; set; }
        public string FollowUp { get; set; }
        public Nullable<System.DateTime> CustomFollowUpStartDate { get; set; }
        public Nullable<System.DateTime> CustomFollowUpEndDate { get; set; }
        public Nullable<System.DateTime> CustomFollowUpReminderDate { get; set; }
        public Nullable<int> ForwardToEmp_ID { get; set; }
        public Nullable<int> Occurance_ID { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> MainTaskID { get; set; }
        public Nullable<int> CampID { get; set; }
    }
}
