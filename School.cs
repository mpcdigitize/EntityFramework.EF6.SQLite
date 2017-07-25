using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.EF6.SQLite
{
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set;}

        public Student Student { get; set; }
        public SchoolZone SchoolZone { get; set;}
    }
}
