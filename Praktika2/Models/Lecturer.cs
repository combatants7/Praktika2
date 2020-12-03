using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2.Models
{
    public class Lecturer:User
    {
        public string Subject { get; set; }
        public int GroupID { get; set; }
    }
}
