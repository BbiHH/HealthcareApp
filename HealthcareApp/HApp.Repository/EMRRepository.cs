using HApp.Domain;
using HApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Repository
{
    public class EMRRepository : BaseRepository<EMR>,IEMRRepository
    {
        public EMRRepository(HappContext context):base(context)
        {
        }
        public EMR FindByPatientPubKey(string PublicKey)
        {
            var enm = _DbSet.Where(t => t.Ppubkey == PublicKey).ToList();
            EMR emr = enm[0];
            return emr;
        }
    }
}