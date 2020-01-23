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
        public List<TypeTicket> TypeTickets = new List<TypeTicket>();
        public List<ScheduleExcurceItem> ScheduleExcurceItems = new List<ScheduleExcurceItem>();
        public List<TypeTicketExcurce> TypeTicketExcurces = new List<TypeTicketExcurce>();

        public void FillExcurceItems()
        {
            TypeExcurces = new List<TypeExcurce>()
            {
                new TypeExcurce()
                {
                   idTypeExcurce = 1,
                   ExcurceName = ""
                }
            };
        }
        public LocalStorage()
        {
            FillExcurceItems();
        }
    }
}
