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
    
    public partial class MITIGATIONPHASE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MITIGATIONPHASE()
        {
            this.MITIGATIONFORCWE = new HashSet<MITIGATIONFORCWE>();
            this.MITIGATIONPHASEFORMITIGATION = new HashSet<MITIGATIONPHASEFORMITIGATION>();
            this.MITIGATIONPHASETAG = new HashSet<MITIGATIONPHASETAG>();
        }
    
        public int MitigationPhaseID { get; set; }
        public string MitigationPhaseGUID { get; set; }
        public Nullable<int> PhaseID { get; set; }
        public string PhaseGUID { get; set; }
        public string MitigationPhaseName { get; set; }
        public string MitigationPhaseDescription { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> ImportanceID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual IMPORTANCE IMPORTANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONFORCWE> MITIGATIONFORCWE { get; set; }
        public virtual PHASE PHASE { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONPHASEFORMITIGATION> MITIGATIONPHASEFORMITIGATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONPHASETAG> MITIGATIONPHASETAG { get; set; }
    }
}
