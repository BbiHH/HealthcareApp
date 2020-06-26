using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HApp.Domain;
using HApp.Repository.Interface;
using HApp.Service.Interface;

namespace HApp.Service
{
    public class CAService : ICAService
    {
        IDoctorRepository doctorRepository;
        IPaientRepository paientRepository;

        public CAService(IDoctorRepository doctorRepository, IPaientRepository paientRepository)
        {
            this.doctorRepository = doctorRepository;
            this.paientRepository = paientRepository;
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctor dr = doctor;
            doctorRepository.Add(dr);
        }

        public void AddPatient(Patient patient)
        {
            Patient pt = patient;
            paientRepository.Add(pt);
        }
    }
}
