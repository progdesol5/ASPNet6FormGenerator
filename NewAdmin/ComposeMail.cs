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
    
    public partial class ComposeMail
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int MyID { get; set; }
        public Nullable<int> CompanyAndContactID { get; set; }
        public string Reference { get; set; }
        public string HtmlTemplate { get; set; }
        public string HtmlLink { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<int> TemplateId { get; set; }
    }
}
