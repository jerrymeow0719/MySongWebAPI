using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace songdbWebAPI.Models
{
    [Table("SongUrl")]
    public class SongUrl
    {
        public int id { get; set; }
        public string songname { get; set; }
        public string singer { get; set; }
        public string songurl { get; set; }
    }
}
