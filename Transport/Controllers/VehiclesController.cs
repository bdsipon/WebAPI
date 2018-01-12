using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.Persistance;
using AutoMapper;
using Transport.Models;
using Transport.Controllers.Resources;

namespace Transport.Controllers
{
    [Produces("application/json")]
    [Route("api/Vehicles")]
    public class VehiclesController : Controller
    {
        private readonly TransportContext context;
        private readonly IMapper mapper;

        public VehiclesController(TransportContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        public IActionResult CreateVehicle([FromBody]VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);
        }
    }
}