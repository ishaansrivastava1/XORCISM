//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWINDOWSModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WINDOWSVOLUMEATTRIBUTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WINDOWSVOLUMEATTRIBUTE()
        {
            this.WINDOWSVOLUMEATTRIBUTESLIST = new HashSet<WINDOWSVOLUMEATTRIBUTESLIST>();
        }
    
        public int WindowsVolumeAttributeID { get; set; }
        public Nullable<int> AttributeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WINDOWSVOLUMEATTRIBUTESLIST> WINDOWSVOLUMEATTRIBUTESLIST { get; set; }
    }
}
