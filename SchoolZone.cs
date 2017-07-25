using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.EF6.SQLite
{
    public class SchoolZone
    {
        [Key]
        public int ZoneId { get; set; }
        public string ZoneName { get; set;}


        public ICollection<School> Schools { get; set;}

    }
}
