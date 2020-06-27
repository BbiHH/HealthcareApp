using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository;
using HApp.Repository.Interface;
using HApp.Service.Interface;

namespace HApp.Service
{
    public class CAService :BaseService, ICAService
    {
        public CAService(HappContext context):base(context)
        {
        }
        public void AddDoctor(Doctor doctor)
        {
            Doctor dr = doctor;
            doctorRepository.Add(dr);
        }

        public void AddPatient(Patient patient)
        {
            Patient pt = patient;
            patientRepository.Add(pt);
        }

        public Doctor FindDoctor(Doctor doctor)
        {
            Doctor dr = doctorRepository.FindById(doctor.ID);
            return dr;
        }

        public Patient FindPatient(Patient patient)
        {
            Patient pt =  patientRepository.FindById(patient.ID);
            return pt;
        }
    }
}
