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
            if (_patients == null) return;
            var patient = _patients.Find(p => p.PatientId == Id);
            if (patient!=null)
            {
                _patients.Remove(patient);
            }
            //throw new NotImplementedException();
        }

        public List<Patient> GetDoctors()
        {
            return _patients;
            //throw new NotImplementedException();
        }

        public Patient GetPatientById(int Id)
        {
            return _patients.FirstOrDefault(p => p.PatientId == Id);
            //throw new NotImplementedException();
        }

        public void UpdatePatient(int Id, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
