namespace HApp.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class Session
    {
        public Guid? PID { get; set; }

        public Guid? DID { get; set; }

        [Key]
        public DateTime Date { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
