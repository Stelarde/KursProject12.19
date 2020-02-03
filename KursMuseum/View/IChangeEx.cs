using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.View
{
    public interface IChangeEx : IView
    {
        string NameExcursion { get; set; }
        DateTime TimeStartExcursion { get; set; }
        DateTime TimeFinishExcursion { get; set; }
        string VenueExcursion { get; set; }
        int QuantityTicketsExcursion { get; set; }
        double StartPriceTicketExcursion { get; set; }
        event EventHandler ChangeExcursion;
    }
}
