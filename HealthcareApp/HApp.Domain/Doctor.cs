namespace HApp.Domain
{
    using System;
    using System.Collections.Generic;


    public partial class Doctor : BaseDomain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor():base()
        {
            ID = Guid.NewGuid();
            Session = new HashSet<Session>();
        }

        public Guid DID { get; set; }

        public string Dname { get; set; }

        public string Dprikey { get; set; }


        public string Dpubkey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
    }
}
