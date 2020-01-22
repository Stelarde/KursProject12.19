using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class SellTicket
    {
        public string idTicket { get; set; }
        public ScheduleItem ScheduleItem { get; set; }
        public DateTime SellTime { get; set; }
        public TypeTicket TypeTicket { get; set; }
        public double PriceTicket { get; set; }

    }
}
