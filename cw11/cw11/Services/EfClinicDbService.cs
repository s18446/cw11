using cw11.DTOs.Requests;
using cw11.DTOs.Responses;
using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class EfClinicDbService : IClinicDbService
    {
        private readonly ClinicDbContext _context;
        public EfClinicDbService(ClinicDbContext context)
        {
            _context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public void ModifyDoctor(Doctor doctor)
        {
            var doc = _context.Doctors.FirstOrDefault(x => x.IdDoctor == doctor.IdDoctor);
            doc.FirstName = doctor.FirstName;
            doc.LastName = doctor.LastName;
            doc.Email = doctor.Email;
            _context.SaveChanges(); 
        }

        public RemoveDoctorResponse RemoveDoctor(RemoveDoctorRequest request)
        {
            var doctor = _context.Doctors.FirstOrDefault(x => x.IdDoctor == request.IdDoctor);
            _context.Remove(doctor);
            _context.SaveChanges();
            return new RemoveDoctorResponse
            {
                IdDoctor = doctor.IdDoctor,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName
            };
        }
    }
}
