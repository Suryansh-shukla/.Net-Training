using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDoctorService:IRepository<Entities.Doctor>
    {
        void AddDoctor(Doctor doctor);
        List<Doctor> GetDoctors();
        Doctor GetDoctorById(int Id);
        void UpdateDoctor(int Id, Doctor doctor);
        void DeleteDoctor(int Id);

    }
}
