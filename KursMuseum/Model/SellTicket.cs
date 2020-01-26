using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursMuseum.Model
{
    public class SellTicket
    {
        //Номер билета
        public string idTicket { get; set; }
        //Время покупки билета    
        public DateTime SellTime { get; set; }
        //Тип билета
        public List<TypeTicketExcursion> TypeTicketExcursion = new List<TypeTicketExcursion>();
        //Стоимость билета
        public double PriceTicket { get; set; }
        //public TypeTicketExcurce TypeTicketExcurce { get; set; }
    }
}