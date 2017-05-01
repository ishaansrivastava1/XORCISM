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
    
    public partial class MIME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MIME()
        {
            this.ATTACHMENT = new HashSet<ATTACHMENT>();
            this.CHECKLISTANSWER = new HashSet<CHECKLISTANSWER>();
            this.EMAILHEADER = new HashSet<EMAILHEADER>();
            this.HTTPREQUESTHEADERFIELDS = new HashSet<HTTPREQUESTHEADERFIELDS>();
            this.HTTPRESPONSEHEADERFIELDS = new HashSet<HTTPRESPONSEHEADERFIELDS>();
            this.MIMEWHITELIST = new HashSet<MIMEWHITELIST>();
        }
    
        public int MIMEID { get; set; }
        public string MIMEType { get; set; }
        public string MIMETypeDescription { get; set; }
        public string MIMEVersion { get; set; }
        public string MIMETypeReference { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTACHMENT> ATTACHMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECKLISTANSWER> CHECKLISTANSWER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAILHEADER> EMAILHEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPREQUESTHEADERFIELDS> HTTPREQUESTHEADERFIELDS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPRESPONSEHEADERFIELDS> HTTPRESPONSEHEADERFIELDS { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MIMEWHITELIST> MIMEWHITELIST { get; set; }
    }
}