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
    
    public partial class Tbl_Applicant_PortFolio
    {
        public int AppID { get; set; }
        public int PortFolioID { get; set; }
        public int LocationID { get; set; }
        public string PortFolioName { get; set; }
        public string PortFolioCategory { get; set; }
        public string PortFolioNote { get; set; }
        public string Avtar { get; set; }
        public Nullable<bool> ActivedBy { get; set; }
        public Nullable<bool> DeletedBy { get; set; }
    }
}
