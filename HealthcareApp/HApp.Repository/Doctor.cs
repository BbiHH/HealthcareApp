namespace HApp.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Session = new HashSet<Session>();
        }

        [Key]
        public Guid DID { get; set; }

        [StringLength(20)]
        public string Dname { get; set; }

        [StringLength(20)]
        public string Dprikey { get; set; }

        [StringLength(20)]
        public string Dpubkey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
    }
}
