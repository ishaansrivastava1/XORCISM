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
    
    public partial class ACCESSRECORDHASH
    {
        public int AccessRecordHashID { get; set; }
        public string AccessRecordHashGUID { get; set; }
        public int AccessRecordID { get; set; }
        public string HashValue { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
    
        public virtual ACCESSRECORD ACCESSRECORD { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
    }
}
