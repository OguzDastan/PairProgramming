using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLib;

namespace PairProgrammingRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private static List<MusicRecords> mList = new List<MusicRecords>()
        {
            new MusicRecords("","",0,DateTime.Now, "")
        };
        // GET: api/Record
        [HttpGet]
        public IEnumerable<MusicRecords> Get()
        {
            return mList;
        }

        // GET: api/Record/5
        [HttpGet("{title}", Name = "Get")]
        public MusicRecords Get(string title)
        {
            return mList.Find(c => c.Title == title);
        }

        // POST: api/Record
        [HttpPost]
        public void Post([FromBody] MusicRecords value)
        {
            mList.Add(value);
        }

        // PUT: api/Record/5
        [HttpPut("{title}")]
        public void Put(string title, [FromBody] MusicRecords value)
        {
            MusicRecords mr = Get(title);
            if (mr != null)
            {
                mr.Title = value.Title;
                mr.Artist = value.Artist;
                mr.Duration = value.Duration;
                mr.PublishDate = value.PublishDate;
                mr.Genre = value.Genre;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{title}")]
        public void Delete(string title)
        {
            MusicRecords mr = Get(title);
            if (mr != null)
            {
                mList.Remove(mr);
            }
        }
    }
}
