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
    
    public partial class session
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public session()
        {
            this.preferences = new HashSet<preference>();
            this.users = new HashSet<user>();
            this.users1 = new HashSet<user>();
            this.users2 = new HashSet<user>();
        }
    
        public System.Guid sess_uuid__uniqueidentifier { get; set; }
        public System.TimeSpan sess_starttime__time { get; set; }
        public System.TimeSpan sess_lastactivity__time { get; set; }
        public Nullable<byte> sess_ipbatch01__tinyint { get; set; }
        public Nullable<byte> sess_ipbatch02__tinyint { get; set; }
        public Nullable<byte> sess_ipbatch03__tinyint { get; set; }
        public Nullable<byte> sess_ipbatch04__tinyint { get; set; }
        public string sess_extradata__nvarchar { get; set; }
        public System.Guid date_uuid__uniqueidentifier { get; set; }
        public System.Guid user_uuid_created__uniqueidentifier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<preference> preferences { get; set; }
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users2 { get; set; }
        public virtual date date { get; set; }
    }
}
