//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class INDICATORTESTMECHANISMRULE
    {
        public int IndicatorTestMechanismRuleID { get; set; }
        public Nullable<int> IndicatorTestMechanismID { get; set; }
        public Nullable<int> RuleID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual INDICATORTESTMECHANISM INDICATORTESTMECHANISM { get; set; }
        public virtual RULE RULE { get; set; }
    }
}