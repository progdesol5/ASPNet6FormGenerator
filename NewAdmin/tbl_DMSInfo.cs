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
    
    public partial class tbl_DMSInfo
    {
        public int ID { get; set; }
        public Nullable<int> DocID { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ContractorId { get; set; }
        public Nullable<int> EngineerId { get; set; }
        public Nullable<int> EmployerId { get; set; }
        public Nullable<int> TenentID { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Title { get; set; }
        public string Request { get; set; }
        public string Spec_DwgRef { get; set; }
        public Nullable<int> Spec_DwgRef2 { get; set; }
        public Nullable<int> Spec_DwgRef3 { get; set; }
        public string Details { get; set; }
        public string IssuedByContractor { get; set; }
        public Nullable<System.DateTime> IssuedByContractorDate { get; set; }
        public string ReceivedByEngineer { get; set; }
        public Nullable<System.DateTime> ReceivedByEngineerDate { get; set; }
        public string Response { get; set; }
        public Nullable<bool> AttachmentID { get; set; }
        public string IssueByEngineer { get; set; }
        public Nullable<System.DateTime> IssuedByEngineerDate { get; set; }
        public string ReceivedByContractor { get; set; }
        public Nullable<System.DateTime> ReceivedByContractorDate { get; set; }
        public string Distribution { get; set; }
        public Nullable<bool> Actived { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> AttachID { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public string MyStatus { get; set; }
        public Nullable<int> ReferenceNo { get; set; }
    }
}
