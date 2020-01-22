using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class ExcurceItem
    {
        public string TypeExc { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public string TypeTicket { get; set; }
        public string PriceTicket { get; set; }
    }
}
