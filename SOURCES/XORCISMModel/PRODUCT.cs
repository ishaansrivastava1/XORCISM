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
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.ASSETPRODUCT = new HashSet<ASSETPRODUCT>();
            this.COOKIENAMEPRODUCT = new HashSet<COOKIENAMEPRODUCT>();
            this.CPEFORPRODUCT = new HashSet<CPEFORPRODUCT>();
            this.EVENTCOLLECTIONMETHOD = new HashSet<EVENTCOLLECTIONMETHOD>();
            this.HTTPHEADERPRODUCT = new HashSet<HTTPHEADERPRODUCT>();
            this.PRODUCTCATEGORYFORPRODUCT = new HashSet<PRODUCTCATEGORYFORPRODUCT>();
            this.PRODUCTEXPLOIT = new HashSet<PRODUCTEXPLOIT>();
            this.PRODUCTFILE = new HashSet<PRODUCTFILE>();
            this.PRODUCTFILELIST = new HashSet<PRODUCTFILELIST>();
            this.PRODUCTMAPPING = new HashSet<PRODUCTMAPPING>();
            this.PRODUCTMAPPING1 = new HashSet<PRODUCTMAPPING>();
            this.PRODUCTPATCH = new HashSet<PRODUCTPATCH>();
            this.PRODUCTPLATFORM = new HashSet<PRODUCTPLATFORM>();
            this.PRODUCTPORT = new HashSet<PRODUCTPORT>();
            this.PRODUCTTAG = new HashSet<PRODUCTTAG>();
            this.RULEPRODUCT = new HashSet<RULEPRODUCT>();
            this.SOFTWARE = new HashSet<SOFTWARE>();
        }
    
        public int ProductID { get; set; }
        public string ProductGUID { get; set; }
        public string ProductName { get; set; }
        public string ProductVendor { get; set; }
        public Nullable<int> OrganisationID { get; set; }
        public string CPEName { get; set; }
        public string ProductEdition { get; set; }
        public string ProductUpdate { get; set; }
        public string ProductVersion { get; set; }
        public Nullable<int> CPEID { get; set; }
        public string ProductLanguage { get; set; }
        public Nullable<int> LocaleID { get; set; }
        public Nullable<int> DeviceID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ProductDescription { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETPRODUCT> ASSETPRODUCT { get; set; }
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COOKIENAMEPRODUCT> COOKIENAMEPRODUCT { get; set; }
        public virtual CPE CPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPEFORPRODUCT> CPEFORPRODUCT { get; set; }
        public virtual DEVICE DEVICE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTCOLLECTIONMETHOD> EVENTCOLLECTIONMETHOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPHEADERPRODUCT> HTTPHEADERPRODUCT { get; set; }
        public virtual LOCALE LOCALE { get; set; }
        public virtual ORGANISATION ORGANISATION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTCATEGORYFORPRODUCT> PRODUCTCATEGORYFORPRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTEXPLOIT> PRODUCTEXPLOIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTFILE> PRODUCTFILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTFILELIST> PRODUCTFILELIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTMAPPING> PRODUCTMAPPING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTMAPPING> PRODUCTMAPPING1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTPATCH> PRODUCTPATCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTPLATFORM> PRODUCTPLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTPORT> PRODUCTPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTTAG> PRODUCTTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RULEPRODUCT> RULEPRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOFTWARE> SOFTWARE { get; set; }
    }
}
