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
    
    public partial class Family
    {
        public int FamilyID { get; set; }
        public string FamilyName { get; set; }
        public string ArabicName { get; set; }
        public string OtherName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<long> crupid { get; set; }
        public Nullable<int> FamilyCode { get; set; }
    }
}