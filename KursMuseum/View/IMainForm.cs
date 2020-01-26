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
        double PriceTickets { get; set; }
        List<ScheduleExcursionItem> ScheduleExcursionItems { get; set; }
        List<string> TypeTickets { get; set; }
        event EventHandler AddEx;
        event EventHandler SoldTickets;
        event EventHandler TypeTicket;
    }
}
