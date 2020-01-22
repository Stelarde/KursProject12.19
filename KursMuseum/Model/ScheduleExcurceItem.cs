using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class ScheduleExcurceItem
    {        
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public TypeExcurce TypeExcurce { get; set; }
        public int PeopleCount { get; set; }
    }
}