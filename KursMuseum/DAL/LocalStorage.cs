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
        public List<SellTicket> SellTickets = new List<SellTicket>();
        public List<TypeTicket> TypeTickets = new List<TypeTicket>();
        public List<ScheduleExcursionItem> ScheduleExcursionItems = new List<ScheduleExcursionItem>();
        public List<TypeTicketExcursion> TypeTicketExcursions = new List<TypeTicketExcursion>();

        public void FillSellTickets()
        {
            //Заполнить
            SellTickets = new List<SellTicket>()
            {
                new SellTicket()
                {
                    idTicket = "2",
                    TimeStart = ScheduleExcursionItems[SellTickets[].idTicket].TimeStart,
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
                    SalesRatio = 1.1,
                    TicketName = "Детский",
                },
                new TypeTicket()
                {
                    SalesRatio = 1.3,
                    TicketName = "Обычный",
                },
                new TypeTicket()
                {
                    SalesRatio = 1.1,
                    TicketName = "Пенсионный",
                }
            };
        }
        public void FillScheduleExcursionItems()
        {
            ScheduleExcursionItems = new List<ScheduleExcursionItem>()
            {
                new ScheduleExcursionItem()
                {
                    TypeExcursion = "Дворцовые перевороты",
                    TimeStart = DateTime.Now,
                    TimeFinish = DateTime.MaxValue,
                    Venue = "3 зал",
                    TicketsLeft = 20,
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
                }
            };
        }
        public LocalStorage()
        {
            FillSellTickets();
            FillTypeTickets();
            FillScheduleExcursionItems();
            FillTypeTicketExcursions();
        }
    }
}