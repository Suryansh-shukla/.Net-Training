using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        List<Patient> GetDoctors();
        Patient GetPatientById(int Id);
        void UpdatePatient(int Id, Patient patient);
        void DeletePatient(int Id);
    }
}
