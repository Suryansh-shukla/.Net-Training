using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        List<Doctor> GetDoctors();
        Doctor GetDoctorById(int Id);
        void UpdateDoctor(int Id, Doctor doctor);
        void DeleteDoctor(int Id);
    }
}
