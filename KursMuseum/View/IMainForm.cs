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
        List<ScheduleExcursionItem> ScheduleExcursionItems {set; }
        List<string> TypeTickets { set; }
        int SelectTypeTckets { get; }
        double SelectMainTale { get; }
        event EventHandler AddEx;
        event EventHandler SoldTickets;
        event EventHandler TypeTicket;
        event EventHandler MainTable;
    }
}
