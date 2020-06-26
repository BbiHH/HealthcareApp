using HApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HApp.Service.Interface
{
    public interface ICAService
    {
        void AddPatient(Patient patient);
        void AddDoctor(Doctor doctor);
    }
}