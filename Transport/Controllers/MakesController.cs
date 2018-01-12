using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport.Models;
using Transport.Persistance;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Transport.Controllers.Resources;


namespace Transport.Controllers
{
    [Produces("application/json")]
    [Route("api/Makes")]
    public class MakesController : Controller
    {
        private readonly TransportContext context;
        private readonly IMapper mapper;

        public MakesController(TransportContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task< IEnumerable<MakeResource>> GetMakes()
        {
           var makes= await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}