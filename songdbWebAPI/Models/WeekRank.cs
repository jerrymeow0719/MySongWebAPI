using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace songdbWebAPI.Models
{
    [Table("WeekRank")]
    public class WeekRank
    {
        public int id { get; set; }
        public int nowactive { get; set; }
        public string indate { get; set; }
        public string songname { get; set; }
        public string singer { get; set; }
        public int songurl { get; set; }
        public int store { get; set; }
        public int songrank { get; set; }
    }
}
