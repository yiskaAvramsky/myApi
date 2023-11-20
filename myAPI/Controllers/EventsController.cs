using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        private readonly IDataContext _context;
        public EventsController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<EventsController>
        [HttpGet]
        // public IEnumerable<Event> Get()
        public IActionResult Get()
        {
            return Ok(_context.EventList );
        }

       

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event eve)
        {
            _context.EventList.Add( new Event { id = _context.count++, title = eve.title, start = eve.start });
            return Ok(_context.EventList);  

        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event eve)
        {
            var f = _context.EventList.Find(e => e.id == id);
            if (f!=null)
            {
                f.title = eve.title;
                f.start = eve.start;
                return Ok();
            }
            else
                return NotFound();
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var eve = _context.EventList.Find(e => e.id == id);
            if (eve!=null)
            {
                _context.EventList.Remove(eve);
                return Ok();
            }
            return  NotFound();


        }
    }
}
