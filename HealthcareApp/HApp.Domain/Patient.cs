namespace HApp.Domain
{
    using System;
    using System.Collections.Generic;

    public partial class Patient : Domain.BaseDomain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient():base()
        {
            ID = Guid.NewGuid();
            Session = new HashSet<Session>();
        }


        public Guid PID { get; set; }


        public string Pname { get; set; }


        public string Pprikey { get; set; }


        public string Ppubkey { get; set; }


        public string SessionKey { get; set; }

        public Guid? EID { get; set; }

        public virtual EMR EMR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Session> Session { get; set; }
    }
}
