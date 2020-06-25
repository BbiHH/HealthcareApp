namespace HApp.Domain
{
    using System;
    using System.Collections.Generic;

    public partial class EMR : BaseClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMR():base()
        {
            Patient = new HashSet<Patient>();
        }

        public Guid EMRID { get; set; }

        public string Ehistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
