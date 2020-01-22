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
        
        public DateTime SellTime { get; set; }
        public TypeTicketExcurce TypeTicketExcurce { get; set; }
        public double PriceTicket { get; set; }

    }
}
