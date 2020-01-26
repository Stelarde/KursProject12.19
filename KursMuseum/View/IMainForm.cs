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
        int CountTickets { get; set; }
        int BalanceTickets { get; set; }
        double Sum { get; set; }
        //List<TypeTicket> TypeTickets { get; set; }
        //List<TypeTicketExcurce> TypeTicketsExcurces { get; set; }
        List<ScheduleExcursionItem> ScheduleExcursionItems { get; set; }

        event EventHandler RaspEx;
        event EventHandler SellForm;
    }
}
