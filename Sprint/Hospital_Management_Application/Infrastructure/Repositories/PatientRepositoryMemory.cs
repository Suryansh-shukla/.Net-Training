using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repositories
{
    public class PatientRepositoryMemory:IPatientService
    {
        private static List<Patient> _patients = new();

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
            //throw new NotImplementedException();
        }

        public void DeletePatient(int Id)
        {
            _patients.Remove(_patients.Find(p=>p.PatientId==Id));
            //throw new NotImplementedException();
        }

        public List<Patient> GetDoctors()
        {
            return _patients;
            //throw new NotImplementedException();
        }

        public Patient GetPatientById(int Id)
        {
            Patient patient = _patients.Find(p => p.PatientId == Id);
            return patient;
            throw new NotImplementedException();
        }

        public void UpdatePatient(int Id, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
