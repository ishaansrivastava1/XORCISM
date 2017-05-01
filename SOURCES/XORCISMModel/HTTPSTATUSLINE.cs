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
    
    public partial class HTTPSTATUSLINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HTTPSTATUSLINE()
        {
            this.HTTPSERVERRESPONSE = new HashSet<HTTPSERVERRESPONSE>();
        }
    
        public int HTTPStatusLineID { get; set; }
        public string Version { get; set; }
        public Nullable<int> VersionID { get; set; }
        public Nullable<int> Status_Code { get; set; }
        public string Reason_Phrase { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPSERVERRESPONSE> HTTPSERVERRESPONSE { get; set; }
        public virtual VERSION VERSION1 { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}