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
    
    public partial class tblSubscriptionSetup
    {
        public int TenentID { get; set; }
        public int locationID { get; set; }
        public int LocalID { get; set; }
        public Nullable<int> days_in_week { get; set; }
        public Nullable<int> DisplayWeek { get; set; }
        public Nullable<bool> AllowCopyFullPlan { get; set; }
        public Nullable<int> LoadFullOrDayitem { get; set; }
        public Nullable<int> DefaultDeliveryTime { get; set; }
        public Nullable<int> DefaultDriverID { get; set; }
        public Nullable<int> DefaultTotWeek { get; set; }
        public Nullable<int> DefaultDayB4PlanStart { get; set; }
        public string Whitch_day_delivery { get; set; }
        public string Week_Start_With_Day { get; set; }
        public Nullable<int> Delivery_in_day { get; set; }
        public string Delivery_time_begin { get; set; }
        public Nullable<bool> Changes_Allowed { get; set; }
        public string Before_how_many_Hours { get; set; }
        public Nullable<bool> Refund_Allowed { get; set; }
        public Nullable<decimal> After_Completion_of_how_many_Percentage_of_Delivery { get; set; }
        public Nullable<int> Created { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string KitchenRequestingStore { get; set; }
        public string MainStore { get; set; }
        public Nullable<bool> IncomingKitchenAutoAccept { get; set; }
        public string planImageLocation { get; set; }
        public string mealimageLocation { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public Nullable<System.DateTime> permsyncdate { get; set; }
        public string permversion { get; set; }
        public Nullable<int> SetMYTRANSID { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public Nullable<int> LifeCycle { get; set; }
        public string Week_Holiday { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
