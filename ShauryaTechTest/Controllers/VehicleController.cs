using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShauryaTechTest.Database;
using ShauryaTechTest.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShauryaTechTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        // GET: api/<VehicleController>
        [HttpGet]
        public List<Vehicle> Get()
        {
            return stt_dbContext._dbContext.Vehicles.ToList();
        }

        // GET api/<VehicleController>/5
        [HttpGet("{VehicleType}/{numberOfRecords}")]
        public List<Vehicle> Get(string VehicleType, int numberOfRecords)
        {
            return stt_dbContext._dbContext.Vehicles.Take(numberOfRecords).Where(s=>s.VehicleType == VehicleType).ToList();
        }

        [HttpGet("{Manufacturingyear}/{numberOfRecords}")]
        public List<Vehicle> Get(int Manufacturingyear, int numberOfRecords)
        {
            return stt_dbContext._dbContext.Vehicles.Take(numberOfRecords).Where(s => s.Manufacturingyear == Manufacturingyear).ToList();
        }

        
    }
}
