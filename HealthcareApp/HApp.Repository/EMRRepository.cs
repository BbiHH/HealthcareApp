using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository
{
    public class EMRRepository : BaseRepository<EMR>
    {
        public EMRRepository(HappContext context):base(context)
        {
        }
    }
}