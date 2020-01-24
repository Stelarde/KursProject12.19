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

        public void FillTypeExcurces()
        {
            TypeExcurces = new List<TypeExcurce>()
            {
                new TypeExcurce()
                {
                   idTypeExcurce = 1,
                   ExcurceName = "Дворцовые перевороты",
                }
            };
        }
        public void FillSellTickets()
        {
            SellTickets = new List<SellTicket>()
            {
                new SellTicket()
                {
                    idTicket = "2",
                    SellTime = DateTime.Now,
                    //TypeTicketExcurce
                    PriceTicket = 15.25,
                }
            };
        }
        public void FillTypeTickets()
        {
            TypeTickets = new List<TypeTicket>()
            {
                new TypeTicket()
                {
                    IdTypeTicket = 3,
                    TicketName = "Детский"
                }
            };
        }
        public void FillScheduleExcurceItems()
        {
            ScheduleExcurceItems = new List<ScheduleExcurceItem>()
            {
                new ScheduleExcurceItem()
                {
                    IdScheduleExcurceItem = 5,
                    STypeExcurce = TypeExcurces[0],//Должен быть лист
                    TimeStart = DateTime.Now,
                    TimeFinish = DateTime.MaxValue,
                    PeopleCount = 20,
                }
            };
        }
        public void FillTypeTicketExcurces()
        {
            TypeTicketExcurces = new List<TypeTicketExcurce>()
            {
                new TypeTicketExcurce()
                {
                    TypeTicket=TypeTickets[0],//Должен быть лист
                    ScheduleExcurceItem = ScheduleExcurceItems[0],//Должен быть лист
                    //price = 13.25,
                }
            };
        }
        public LocalStorage()
        {
            FillTypeExcurces();
            FillSellTickets();
            FillTypeTickets();
            FillScheduleExcurceItems();
            FillTypeTicketExcurces();
        }
    }
}
