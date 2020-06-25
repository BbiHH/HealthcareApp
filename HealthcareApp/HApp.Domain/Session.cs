namespace HApp.Domain
{
    using System;

    public partial class Session
    {
        public Guid? PID { get; set; }

        public Guid? DID { get; set; }

        public DateTime Date { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
