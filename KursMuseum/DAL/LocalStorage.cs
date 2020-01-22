using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;

namespace KursMuseum.DAL
{
    public class LocalStorage
    {
        public List<TypeExcurce> TypeExcurces = new List<TypeExcurce>();        
        public List<SellTicket> SellTickets = new List<SellTicket>();
        public List<ScheduleExcurceItem> ScheduleExcurceItems = new List<ScheduleExcurceItem>();
        public List<TypeTicketExcurce> TypeTicketExcurces = new List<TypeTicketExcurce>();

        public void FillExcurceItems()
        {
            ExcurceItems = new List<ExcurceItem>()
            {
                new ExcurceItem()
                {
                   TypeExc = "1",
                   TypeTicket = "2",
                   PriceTicket = 14.88

                }
            };
        }
    }
}
