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
    
    public partial class COOKIENAMEORGANISATION
    {
        public int CookieNameOrganisationID { get; set; }
        public Nullable<int> OrganisationID { get; set; }
        public string OrganisationGUID { get; set; }
        public string CookieNameOrganisationRelationship { get; set; }
        public string CookieNameOrganisationDescription { get; set; }
        public Nullable<int> CookieNameID { get; set; }
        public string CookieNameGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual COOKIENAME COOKIENAME { get; set; }
        public virtual COOKIENAMEORGANISATION COOKIENAMEORGANISATION1 { get; set; }
        public virtual COOKIENAMEORGANISATION COOKIENAMEORGANISATION2 { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual ORGANISATION ORGANISATION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
