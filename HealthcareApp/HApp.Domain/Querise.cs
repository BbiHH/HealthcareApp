﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HApp.Domain
{
    public class Querise
    {
        public Guid EID { get; set; }

        public Guid DID { get; set; }

        [Key]
        public string SessionKey { get; set; }
    }
}
