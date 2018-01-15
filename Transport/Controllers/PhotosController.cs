using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.Core;

namespace Transport.Controllers
{
    [Produces("application/json")]
    [Route("api/Photos")]
    public class PhotosController : Controller
    {
        private readonly IHostingEnvironment host;
        private readonly IVehicleRepository vehicleRepository;

        public PhotosController(IHostingEnvironment host,IVehicleRepository vehicleRepository)
        {
            this.host = host;
            this.vehicleRepository = vehicleRepository;
        }

      //  [HttpPost]

        //public IActionResult Upload(int VehicleId,IFormFile File)
        //{
        //    var vehicle = await vehicleRepository.GetVehicle(VehicleId, includeRelated: false);
        //    if (vehicle == null)
        //        return NotFound();

        //}
    }
}