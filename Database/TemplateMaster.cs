//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class TemplateMaster
    {
        public int TemplateKey { get; set; }
        public string TemplateName { get; set; }
        public string Descriptions { get; set; }
        public string TemplateType { get; set; }
        public Nullable<int> CategoryKey { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> TenentID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}