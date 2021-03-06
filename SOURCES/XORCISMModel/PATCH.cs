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
    
    public partial class PATCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATCH()
        {
            this.CPEPATCH = new HashSet<CPEPATCH>();
            this.FIXACTIONPATCH = new HashSet<FIXACTIONPATCH>();
            this.OSPATCH = new HashSet<OSPATCH>();
            this.PATCHREFERENCE = new HashSet<PATCHREFERENCE>();
            this.PRODUCTPATCH = new HashSet<PRODUCTPATCH>();
        }
    
        public int PatchID { get; set; }
        public string PatchGUID { get; set; }
        public string PatchVocabularyID { get; set; }
        public string PatchTitle { get; set; }
        public string PatchDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> RepositoryID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPEPATCH> CPEPATCH { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIXACTIONPATCH> FIXACTIONPATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OSPATCH> OSPATCH { get; set; }
        public virtual REPOSITORY REPOSITORY { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATCHREFERENCE> PATCHREFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTPATCH> PRODUCTPATCH { get; set; }
    }
}
