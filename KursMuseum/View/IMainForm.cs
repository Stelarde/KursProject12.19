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
        event EventHandler RaspEx;
        event EventHandler SellForm;
    }
}
