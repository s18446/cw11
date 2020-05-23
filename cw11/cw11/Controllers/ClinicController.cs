using cw11.DTOs.Requests;
using cw11.DTOs.Responses;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Controllers
{
    [Route("api/clinic")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicDbService _service;

        public ClinicController(IClinicDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetMedicament()
        {
            return Ok(_service.GetDoctors());
        }

        
        [HttpPost("remove")]
        public IActionResult RemoveDoctor(RemoveDoctorRequest request)
        {
            RemoveDoctorResponse resp;
            try
            {
               resp = _service.RemoveDoctor(request);
            }catch(Exception ex)
            {
                return BadRequest("something went wrong " + ex);
            }
            return Ok(resp);
        }

        [HttpPost]
        public IActionResult AddNewDoctor(Doctor doctor)
        {
            try
            {
                _service.AddDoctor(doctor);
            }
            catch (Exception exc)
            {
                return BadRequest("something went wrong " + exc);
            }
            return Ok("added");
        }
        [HttpPut]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            try
            {
                _service.ModifyDoctor(doctor);
            }
            catch (Exception exc)
            {
                return BadRequest("something went wrong " + exc);
            }
            return Ok("modified " + doctor.IdDoctor);
        }
    }
}
