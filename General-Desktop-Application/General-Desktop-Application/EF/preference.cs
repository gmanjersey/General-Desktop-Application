//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace General_Desktop_Application.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class preference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public preference()
        {
            this.preference1 = new HashSet<preference>();
        }
    
        public System.Guid pref_uuid__uniqueidentifier { get; set; }
        public int pref_type__int { get; set; }
        public Nullable<bool> pref_value__bit { get; set; }
        public Nullable<byte> pref_value__tinyint { get; set; }
        public Nullable<int> pref_value__int { get; set; }
        public string pref_value__nvarchar { get; set; }
        public System.Guid user_uuid__uniqueidentifier { get; set; }
        public System.Guid sess_uuid_created__uniqueidentifier { get; set; }
        public Nullable<System.Guid> pref_uuid_root__uniqueidentifier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<preference> preference1 { get; set; }
        public virtual preference preference2 { get; set; }
        public virtual session session { get; set; }
        public virtual user user { get; set; }
    }
}
