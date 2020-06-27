namespace HApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Session
    {
        public Guid PID { get; set; }

        public Guid DID { get; set; }

        [Key]
        public DateTime Date { get; set; }

    }
}
