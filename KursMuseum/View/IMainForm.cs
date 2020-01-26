using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.View
{
    public interface IMainForm : IView
    {
        int PriceTickets { get; set; }
        //List<TypeTicket> TypeTickets { get; set; }
        //List<TypeTicketExcurce> TypeTicketsExcurces { get; set; }
        List<ScheduleExcursionItem> ScheduleExcursionItems { get; set; }
        List<string> TypeTickets { get; set; }
        event EventHandler AddEx;
        event EventHandler SoldTickets;
    }
}
