using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace songdbWebAPI.Models
{
    [Table("NewSong")]
    public class NewSong
    {
        public int id { get; set; }
        public int nowactive { get; set; }
        public string indate { get; set; }
        public string songname { get; set; }
        public string singer { get; set; }
        public int songurl { get; set; }
        public int webclass1 { get; set; }
        public int webclass2 { get; set; }
        public int webclass3 { get; set; }
    }
}
