//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTHREATModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class THREATACTORGROUPTACTIC
    {
        public int ThreatActorGroupTacticID { get; set; }
        public int ThreatActorGroupID { get; set; }
        public string ThreatActorGroupGUID { get; set; }
        public int TacticID { get; set; }
        public string TacticGUID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual THREATACTORGROUP THREATACTORGROUP { get; set; }
    }
}
