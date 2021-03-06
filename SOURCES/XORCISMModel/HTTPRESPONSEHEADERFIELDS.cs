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
    
    public partial class HTTPRESPONSEHEADERFIELDS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HTTPRESPONSEHEADERFIELDS()
        {
            this.HTTPRESPONSEHEADER = new HashSet<HTTPRESPONSEHEADER>();
        }
    
        public int HTTPResponseHeaderFieldsID { get; set; }
        public string Access_Control_Allow_Origin { get; set; }
        public string Accept_Ranges { get; set; }
        public Nullable<int> Age { get; set; }
        public string Cache_Control { get; set; }
        public string Connection { get; set; }
        public string Content_Encoding { get; set; }
        public string Content_Language { get; set; }
        public Nullable<int> Content_Length { get; set; }
        public string Content_Location { get; set; }
        public string Content_MD5 { get; set; }
        public string Content_Disposition { get; set; }
        public string Content_Range { get; set; }
        public string Content_Type { get; set; }
        public Nullable<int> ContentMIMEID { get; set; }
        public Nullable<System.DateTimeOffset> Date { get; set; }
        public string ETag { get; set; }
        public Nullable<System.DateTimeOffset> Expires { get; set; }
        public Nullable<System.DateTimeOffset> Last_Modified { get; set; }
        public string Link { get; set; }
        public string Location { get; set; }
        public Nullable<int> LocationURIID { get; set; }
        public string P3P { get; set; }
        public string Pragma { get; set; }
        public string Proxy_Authenticate { get; set; }
        public Nullable<int> Refresh { get; set; }
        public Nullable<int> Retry_After { get; set; }
        public string Server { get; set; }
        public string Set_Cookie { get; set; }
        public string Strict_Transport_Security { get; set; }
        public string Trailer { get; set; }
        public string Transfer_Encoding { get; set; }
        public string Vary { get; set; }
        public Nullable<int> VaryURIID { get; set; }
        public string Via { get; set; }
        public string Warning { get; set; }
        public string WWW_Authenticate { get; set; }
        public string X_Frame_Options { get; set; }
        public string X_XSS_Protection { get; set; }
        public string X_Content_Type_Options { get; set; }
        public string X_Forwarded_Proto { get; set; }
        public string X_Powered_By { get; set; }
        public string X_UA_Compatible { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<int> CollectionToolID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
    
        public virtual COLLECTIONMETHOD COLLECTIONMETHOD { get; set; }
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HTTPRESPONSEHEADER> HTTPRESPONSEHEADER { get; set; }
        public virtual MIME MIME { get; set; }
        public virtual TOOL TOOL { get; set; }
        public virtual URIOBJECT URIOBJECT { get; set; }
        public virtual URIOBJECT URIOBJECT1 { get; set; }
    }
}
