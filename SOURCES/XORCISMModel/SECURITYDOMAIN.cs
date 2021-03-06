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
    
    public partial class SECURITYDOMAIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECURITYDOMAIN()
        {
            this.SECURITYDOMAINMATURITY = new HashSet<SECURITYDOMAINMATURITY>();
            this.SECURITYDOMAINOBJECTIVE = new HashSet<SECURITYDOMAINOBJECTIVE>();
            this.SECURITYDOMAINPROCESS = new HashSet<SECURITYDOMAINPROCESS>();
            this.SECURITYDOMAINTAG = new HashSet<SECURITYDOMAINTAG>();
        }
    
        public int SecurityDomainID { get; set; }
        public string SecurityDomainGUID { get; set; }
        public string SecurityDomainName { get; set; }
        public string SecurityDomainDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYDOMAINMATURITY> SECURITYDOMAINMATURITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYDOMAINOBJECTIVE> SECURITYDOMAINOBJECTIVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYDOMAINPROCESS> SECURITYDOMAINPROCESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYDOMAINTAG> SECURITYDOMAINTAG { get; set; }
    }
}
