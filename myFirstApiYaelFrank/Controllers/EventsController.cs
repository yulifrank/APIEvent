using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;


namespace myFirstApiYaelFrank.Controllers
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
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.EventList);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id >= _context.EventList.Count)
                return NotFound();

            return Ok(_context.EventList[id].Title);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Event value)
        {
            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            _context.EventList.Add(new Event { Id = Event.index, Title = value.Title, Start = value.Start });

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event value)
        {
            if (id >= _context.EventList.Count)
                return NotFound();

            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            var e = _context.EventList.Find(e => e.Id == id);
            e.Title = value.Title;
            e.Start = value.Start;

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= _context.EventList.Count)
                return NotFound();

            var e = _context.EventList.Find(e => e.Id == id);
            _context.EventList.Remove(e);

            return Ok();
        }
    }
}
