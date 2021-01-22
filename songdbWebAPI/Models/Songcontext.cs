using System;
using Microsoft.EntityFrameworkCore;

namespace songdbWebAPI.Models
{
    public class Songcontext : DbContext
    {
        public Songcontext(DbContextOptions<Songcontext> options) : base(options)
        {
        }

        public DbSet<NewSong> NewSongs { get; set; }
        public DbSet<SongUrl> SongUrls { get; set; }
        public DbSet<WeekRank> WeekRanks { get; set; }
    }
}