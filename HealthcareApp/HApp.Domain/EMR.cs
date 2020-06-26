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


        public string Ehistory { get; set; }

        public string Ppubkey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
