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
    
    public partial class ARCHIVEFILEFORMAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARCHIVEFILEFORMAT()
        {
            this.ARCHIVEFILE = new HashSet<ARCHIVEFILE>();
            this.ARCHIVEFILEFORMATEXTENSION = new HashSet<ARCHIVEFILEFORMATEXTENSION>();
        }
    
        public int ArchiveFileFormatID { get; set; }
        public string ArchiveFileFormatGUID { get; set; }
        public string ArchiveFileFormatName { get; set; }
        public string ArchiveFileFormatDescription { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARCHIVEFILE> ARCHIVEFILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARCHIVEFILEFORMATEXTENSION> ARCHIVEFILEFORMATEXTENSION { get; set; }
    }
}