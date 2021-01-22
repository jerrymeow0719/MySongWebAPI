using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using songdbWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace songdbWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class SongController : Controller
    {
        private readonly Songcontext _context;

        public SongController(Songcontext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MySong>>> GetSongs([FromQuery] int songtype, [FromQuery] int store)
        {
            List<MySong> mySong = new List<MySong>();
            if (songtype == 1)
            {
                var dbList = await _context.NewSongs.Where(s => s.nowactive == 1).ToListAsync();
                foreach (NewSong newSong in dbList)
                {
                    mySong.Add(
                        new MySong
                        {
                            songname = newSong.songname,
                            singer = newSong.singer,
                            songurl = _context.SongUrls.Where(s => s.id == newSong.songurl).ToList()[0].songurl,
                            webclass1 = newSong.webclass1,
                            webclass2 = newSong.webclass2,
                            webclass3 = newSong.webclass3
                        });
                }
            }
            else if(songtype == 2)
            {
                var dbList = await _context.WeekRanks.Where(s => s.store == store && s.nowactive == 1).ToListAsync();
                foreach (WeekRank rankSong in dbList)
                {
                    mySong.Add(
                        new MySong
                        {
                            songname = rankSong.songname,
                            singer = rankSong.singer,
                            songurl = _context.SongUrls.Where(s => s.id == rankSong.songurl).ToList()[0].songurl,
                            webclass1 = (store == 1) ? 1 : 0,
                            webclass2 = (store == 2) ? 1 : 0,
                            webclass3 = (store == 3) ? 1 : 0
                        });
                }
            }
            return mySong;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
