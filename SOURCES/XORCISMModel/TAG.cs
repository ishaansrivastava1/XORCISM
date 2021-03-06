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
    
    public partial class TAG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAG()
        {
            this.CCEPARAMETERTAG = new HashSet<CCEPARAMETERTAG>();
            this.CCETECHNICALMECHANISMTAG = new HashSet<CCETECHNICALMECHANISMTAG>();
            this.CONTROLTAG = new HashSet<CONTROLTAG>();
            this.CPETAG = new HashSet<CPETAG>();
            this.CWEALTERNATETERMTAG = new HashSet<CWEALTERNATETERMTAG>();
            this.CWEATTACKCONSEQUENCETAG = new HashSet<CWEATTACKCONSEQUENCETAG>();
            this.CWEMODEOFINTRODUCTIONTAG = new HashSet<CWEMODEOFINTRODUCTIONTAG>();
            this.CWETAG = new HashSet<CWETAG>();
            this.EMAILMESSAGETAG = new HashSet<EMAILMESSAGETAG>();
            this.EXPLOITTAG = new HashSet<EXPLOITTAG>();
            this.FILETAG = new HashSet<FILETAG>();
            this.FINDINGTAG = new HashSet<FINDINGTAG>();
            this.HEADERTAG = new HashSet<HEADERTAG>();
            this.METHODOLOGYTAG = new HashSet<METHODOLOGYTAG>();
            this.METRICTAG = new HashSet<METRICTAG>();
            this.MITIGATIONPHASETAG = new HashSet<MITIGATIONPHASETAG>();
            this.MITIGATIONSTRATEGYTAG = new HashSet<MITIGATIONSTRATEGYTAG>();
            this.OBFUSCATIONTECHNIQUETAG = new HashSet<OBFUSCATIONTECHNIQUETAG>();
            this.OBJECTIVETAG = new HashSet<OBJECTIVETAG>();
            this.PARAMETERTAG = new HashSet<PARAMETERTAG>();
            this.PHASETAG = new HashSet<PHASETAG>();
            this.PHYSICALLOCATIONTAG = new HashSet<PHYSICALLOCATIONTAG>();
            this.PLATFORMTAG = new HashSet<PLATFORMTAG>();
            this.PRODUCTTAG = new HashSet<PRODUCTTAG>();
            this.PROJECTTAG = new HashSet<PROJECTTAG>();
            this.RECOMMENDATIONTAG = new HashSet<RECOMMENDATIONTAG>();
            this.REFERENCETAG = new HashSet<REFERENCETAG>();
            this.SECURITYCONTROLTAG = new HashSet<SECURITYCONTROLTAG>();
            this.SECURITYCONTROLTYPETAG = new HashSet<SECURITYCONTROLTYPETAG>();
            this.SECURITYDOMAINTAG = new HashSet<SECURITYDOMAINTAG>();
            this.SECURITYMETRICTAG = new HashSet<SECURITYMETRICTAG>();
            this.SECURITYPRINCIPLETAG = new HashSet<SECURITYPRINCIPLETAG>();
            this.SECURITYREQUIREMENTTAG = new HashSet<SECURITYREQUIREMENTTAG>();
            this.SKILLCATEGORYTAG = new HashSet<SKILLCATEGORYTAG>();
            this.SKILLTAG = new HashSet<SKILLTAG>();
            this.STANDARDTAG = new HashSet<STANDARDTAG>();
            this.TAGFORASSET = new HashSet<TAGFORASSET>();
            this.TAGTAG = new HashSet<TAGTAG>();
            this.TAGTAG1 = new HashSet<TAGTAG>();
            this.TASKTAG = new HashSet<TASKTAG>();
            this.TECHNIQUEREFERENCETAG = new HashSet<TECHNIQUEREFERENCETAG>();
            this.TECHNIQUETAG = new HashSet<TECHNIQUETAG>();
            this.TECHNOLOGYTAG = new HashSet<TECHNOLOGYTAG>();
            this.TOOLTAG = new HashSet<TOOLTAG>();
            this.VOCABULARYTAG = new HashSet<VOCABULARYTAG>();
        }
    
        public int TagID { get; set; }
        public string TagGUID { get; set; }
        public string TagValue { get; set; }
        public Nullable<bool> casesensitive { get; set; }
        public string TagDescription { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> ImportanceID { get; set; }
        public string TagType { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<int> ToolID { get; set; }
        public string ToolGUID { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string SourceGUID { get; set; }
        public Nullable<int> AssetID { get; set; }
        public string AssetGUID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public string AccountGUID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string UserGUID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string VocabularyGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ValidityID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public Nullable<int> TrustReasonID { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual ASSET ASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEPARAMETERTAG> CCEPARAMETERTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCETECHNICALMECHANISMTAG> CCETECHNICALMECHANISMTAG { get; set; }
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLTAG> CONTROLTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPETAG> CPETAG { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWEALTERNATETERMTAG> CWEALTERNATETERMTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWEATTACKCONSEQUENCETAG> CWEATTACKCONSEQUENCETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWEMODEOFINTRODUCTIONTAG> CWEMODEOFINTRODUCTIONTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CWETAG> CWETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILMESSAGETAG> EMAILMESSAGETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPLOITTAG> EXPLOITTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILETAG> FILETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FINDINGTAG> FINDINGTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HEADERTAG> HEADERTAG { get; set; }
        public virtual IMPORTANCE IMPORTANCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METHODOLOGYTAG> METHODOLOGYTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METRICTAG> METRICTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONPHASETAG> MITIGATIONPHASETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MITIGATIONSTRATEGYTAG> MITIGATIONSTRATEGYTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBFUSCATIONTECHNIQUETAG> OBFUSCATIONTECHNIQUETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBJECTIVETAG> OBJECTIVETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARAMETERTAG> PARAMETERTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHASETAG> PHASETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHYSICALLOCATIONTAG> PHYSICALLOCATIONTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMTAG> PLATFORMTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTTAG> PRODUCTTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECTTAG> PROJECTTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECOMMENDATIONTAG> RECOMMENDATIONTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REFERENCETAG> REFERENCETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYCONTROLTAG> SECURITYCONTROLTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYCONTROLTYPETAG> SECURITYCONTROLTYPETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYDOMAINTAG> SECURITYDOMAINTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYMETRICTAG> SECURITYMETRICTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYPRINCIPLETAG> SECURITYPRINCIPLETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECURITYREQUIREMENTTAG> SECURITYREQUIREMENTTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILLCATEGORYTAG> SKILLCATEGORYTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILLTAG> SKILLTAG { get; set; }
        public virtual SOURCE SOURCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STANDARDTAG> STANDARDTAG { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual TRUSTREASON TRUSTREASON { get; set; }
        public virtual USER USER { get; set; }
        public virtual VALIDITY VALIDITY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAGFORASSET> TAGFORASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAGTAG> TAGTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAGTAG> TAGTAG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASKTAG> TASKTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNIQUEREFERENCETAG> TECHNIQUEREFERENCETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNIQUETAG> TECHNIQUETAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TECHNOLOGYTAG> TECHNOLOGYTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOOLTAG> TOOLTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOCABULARYTAG> VOCABULARYTAG { get; set; }
    }
}
