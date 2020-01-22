using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class Schedule
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public string NameEx { get; set; }
        public int Count { get; set; }
    }
}