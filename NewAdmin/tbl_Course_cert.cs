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
    
    public partial class tbl_Course_cert
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int CourseManagementNo { get; set; }
        public int InstructorContactMyID { get; set; }
        public int Studentemp_id { get; set; }
        public int CerticateNo { get; set; }
        public int CerticateSerialNo { get; set; }
        public int MYID { get; set; }
        public Nullable<int> coordinatoremp_id { get; set; }
        public Nullable<System.DateTime> CerticateIssueDate { get; set; }
        public Nullable<int> SignatureEmp_ID { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> CruipID { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}