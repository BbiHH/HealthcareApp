namespace HApp.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Session = new HashSet<Session>();
        }

        [Key]
        public Guid PID { get; set; }

        [StringLength(20)]
        public string Pname { get; set; }

        [StringLength(20)]
        public string Pprikey { get; set; }

        [StringLength(20)]
        public string Ppubkey { get; set; }

        [StringLength(20)]
        public string SessionKey { get; set; }

        public Guid? EID { get; set; }

        public virtual EMR EMR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
    }
}
