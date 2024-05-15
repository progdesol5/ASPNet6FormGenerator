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
    
    public partial class Campaign_Master
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int CampaignID { get; set; }
        public Nullable<int> CampaignType { get; set; }
        public string CampaignName { get; set; }
        public Nullable<int> SpendID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> ProductType { get; set; }
        public Nullable<int> PurchaseType { get; set; }
        public Nullable<System.DateTime> CStartDate { get; set; }
        public Nullable<System.DateTime> CEndDate { get; set; }
        public Nullable<System.DateTime> CExpirationDate { get; set; }
        public Nullable<bool> CActive { get; set; }
        public Nullable<bool> CDelete { get; set; }
        public Nullable<decimal> CMaxDiscount { get; set; }
        public Nullable<decimal> CMinDiscount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<decimal> CTotalAcmount { get; set; }
        public string CRedemption { get; set; }
        public string ProductQuantity { get; set; }
        public Nullable<int> RewardType { get; set; }
        public Nullable<bool> CIsSingle { get; set; }
        public Nullable<bool> CIsMultiple { get; set; }
        public string CPercentageDiscount { get; set; }
        public Nullable<int> CRewardCreditOffer { get; set; }
        public Nullable<decimal> SpendGoal { get; set; }
        public Nullable<int> ProductGoal { get; set; }
    }
}
