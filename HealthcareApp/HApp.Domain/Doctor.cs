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
            Querises = new HashSet<Querise>();
            Sessions = new HashSet<Session>();
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Querise> Querises { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
