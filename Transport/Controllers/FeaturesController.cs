using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.Persistance;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Transport.Controllers.Resources;
using Transport.Models;

namespace Transport.Controllers
{
    [Produces("application/json")]
    [Route("api/Features")]
    public class FeaturesController : Controller
    {
        private readonly TransportContext context;
        private readonly IMapper mapper;

        public FeaturesController(TransportContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task< IEnumerable<KeyValuePairResource>> GetFeature()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
           
    }
}