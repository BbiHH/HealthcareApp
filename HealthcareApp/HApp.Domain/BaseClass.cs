using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Domain
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            ID = Guid.NewGuid();
        }
        /// <summary>
        /// ID
        /// </summary>
        public Guid ID
        {
            get;set;
        }
    }
}