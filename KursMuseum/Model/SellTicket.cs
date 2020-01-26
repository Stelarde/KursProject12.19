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
        //Время начала экскурсии
        public string TimeStart { get; set; }
        //Тип билета
        public string TypeTicket { get; set; }
        //Цена
        public string Price { get; set; }
        //Время продажи билета    
        public DateTime SellTime { get; set; }
        //Тип билета
        public List<TypeTicketExcursion> TypeTicketExcursion = new List<TypeTicketExcursion>();
        //Стоимость билета
        public double PriceTicket { get; set; }
    }
}