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
    
    public partial class EVENTPROPERTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENTPROPERTY()
        {
            this.EVENTPROPERTYADDRESS = new HashSet<EVENTPROPERTYADDRESS>();
            this.EVENTPROPERTYFOREVENT = new HashSet<EVENTPROPERTYFOREVENT>();
        }
    
        public int EventPropertyID { get; set; }
        public string EventPropertyGUID { get; set; }
        public string EventPropertyIDREF { get; set; }
        public string EventPropertyName { get; set; }
        public string EventPropertyDescription { get; set; }
        public Nullable<bool> appears_random { get; set; }
        public string datatype { get; set; }
        public Nullable<int> VocabularyID { get; set; }
    
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTPROPERTYADDRESS> EVENTPROPERTYADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTPROPERTYFOREVENT> EVENTPROPERTYFOREVENT { get; set; }
    }
}
