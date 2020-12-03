using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2.Models
{
    public class LecturerSubject
    {
        public int ID { get; set; }
        public int SubjectID { get; set; }
        public int StaffID { get; set; }
        public int GroupID { get; set; }
    }
}
