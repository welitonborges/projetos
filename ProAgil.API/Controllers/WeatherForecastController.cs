using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.Data;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos.ToList();
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);            
        }
    }
}
