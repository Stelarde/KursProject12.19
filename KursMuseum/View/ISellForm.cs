using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.View
{
    public interface ISellForm : IView
    {
        List<SellTicket> SellTickets { get; set; }
    }
}
