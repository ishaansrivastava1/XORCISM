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
    
    public partial class STANDARDORGANISATION
    {
        public int StandardOrganisationID { get; set; }
        public int StandardID { get; set; }
        public string RelationshipName { get; set; }
        public int OrganisationID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual ORGANISATION ORGANISATION { get; set; }
        public virtual STANDARD STANDARD { get; set; }
    }
}