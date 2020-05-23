using cw11.DTOs.Requests;
using cw11.DTOs.Responses;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IClinicDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public RemoveDoctorResponse RemoveDoctor(RemoveDoctorRequest request);

        public void AddDoctor(Doctor doctor);
        public void ModifyDoctor(Doctor doctor);
        
    }
}
