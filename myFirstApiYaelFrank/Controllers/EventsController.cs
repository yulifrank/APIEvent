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
        static Data context = new Data();

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(context.EventList);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (id >= context.EventList.Count)
                return NotFound();

            return Ok(context.EventList[id].Title);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Event value)
        {
            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            context.EventList.Add(new Event { Id = Event.index, Title = value.Title, Start = value.Start });

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event value)
        {
            if (id >= context.EventList.Count)
                return NotFound();

            if (string.IsNullOrEmpty(value.Title) || value.Start == null)
                return BadRequest();

            var e = context.EventList.Find(e => e.Id == id);
            e.Title = value.Title;
            e.Start = value.Start;

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= context.EventList.Count)
                return NotFound();

            var e = context.EventList.Find(e => e.Id == id);
            context.EventList.Remove(e);

            return Ok();
        }
    }
}
