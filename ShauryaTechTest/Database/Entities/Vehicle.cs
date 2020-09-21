using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTechTest.Database.Entities
{
    public class Vehicle
    {
        [Key]
        public string VehicleNumber { get; set; }
        public string VehicleType { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public int Manufacturingyear { get; set; }
        public string LoadCarryingCapacity { get; set; }
        public string Makeofvehicle { get; set; }
        public string ModelNumber { get; set; }
        public string BodyType { get; set; }
        public string OrganisationName { get; set; }
        public string DeviceID { get; set; }
        
        public string UserID { get; set; }
        public User user { get; set; } 

    }
}
