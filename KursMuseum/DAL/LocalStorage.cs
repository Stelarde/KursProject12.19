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
        public List<TypeExcursion> TypeExcursions = new List<TypeExcursion>();        
        public List<SellTicket> SellTickets = new List<SellTicket>();
        public List<TypeTicket> TypeTickets = new List<TypeTicket>();
        public List<ScheduleExcursionItem> ScheduleExcursionItems = new List<ScheduleExcursionItem>();
        public List<TypeTicketExcursion> TypeTicketExcursions = new List<TypeTicketExcursion>();

        public void FillTypeExcursions()
        {
            TypeExcursions = new List<TypeExcursion>()
            {
                new TypeExcursion()
                {
                   idTypeExcursion = 1,
                   ExcursionName = "Дворцовые перевороты",
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
                    TypeTicketExcursion = TypeTicketExcursions,
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
        public void FillScheduleExcursionItems()
        {
            ScheduleExcursionItems = new List<ScheduleExcursionItem>()
            {
                new ScheduleExcursionItem()
                {
                    IdScheduleExcursionItem = 0,
                    TypeExcursion = TypeExcursions[0].ExcursionName,
                    TimeStart = DateTime.Now,
                    TimeFinish = DateTime.MaxValue,
                    PeopleCount = 20,
                }
            };
        }
        public void FillTypeTicketExcursions()
        {
            TypeTicketExcursions = new List<TypeTicketExcursion>()
            {
                new TypeTicketExcursion()
                {
                    TypeTickets = TypeTickets,
                    ScheduleExcursionItems = ScheduleExcursionItems,
                    //price = 13.25,
                }
            };
        }
        public LocalStorage()
        {
            FillTypeExcursions();
            FillSellTickets();
            FillTypeTickets();
            FillScheduleExcursionItems();
            FillTypeTicketExcursions();
        }
    }
}