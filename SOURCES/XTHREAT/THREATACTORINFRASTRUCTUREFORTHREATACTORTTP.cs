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
    
    public partial class THREATACTORINFRASTRUCTUREFORTHREATACTORTTP
    {
        public int ThreatActorTTPInfrastructureID { get; set; }
        public int ThreatActorInfrastructureID { get; set; }
        public int ThreatActorTTPID { get; set; }
        public string Information_Source { get; set; }
        public string ConfidenceLevel { get; set; }
        public System.DateTimeOffset CreatedDate { get; set; }
        public System.DateTimeOffset timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual THREATACTORINFRASTRUCTURE THREATACTORINFRASTRUCTURE { get; set; }
        public virtual THREATACTORTTP THREATACTORTTP { get; set; }
    }
}
