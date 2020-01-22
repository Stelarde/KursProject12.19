using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class TypeTicketExcurce
    {
        public TypeTicket TypeTicket { get; set; }
        public ScheduleExcurceItem ScheduleExcurceItem { get; set; }
        public double price { get; set; }
    }
}
