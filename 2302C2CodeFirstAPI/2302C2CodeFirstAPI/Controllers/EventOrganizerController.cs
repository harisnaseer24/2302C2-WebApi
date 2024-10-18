using _2302C2CodeFirstAPI.Data;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2302C2CodeFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventOrganizerController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public EventOrganizerController(ApplicationDbContext _db)
        {
            db= _db;
            
        }
        [HttpGet]
        public IActionResult GetEvents() {

            var events = db.Events.Include(q=>q.EventType);
            return Ok(events);
              
        }


    }
}
