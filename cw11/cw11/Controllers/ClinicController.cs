using cw11.Models;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ClinicDbContext _context;

        public ClinicController(ClinicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMedicament()
        {
            return Ok();
        }

    }
}
