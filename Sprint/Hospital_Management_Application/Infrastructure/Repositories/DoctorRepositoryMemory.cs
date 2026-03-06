using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Infrastructure.Repositories
{
    public class DoctorRepositoryMemory
    {
        private static List<Doctor> _doctors = new();
    }
}
