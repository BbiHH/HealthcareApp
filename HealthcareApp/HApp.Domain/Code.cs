using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HApp.Domain
{
    public class Code
    {
        public string Cprikey { get; set; }
        public string Cpubkey { get; set; }
        [Key]
        public string SessionKey { get; set; }
    }
}
