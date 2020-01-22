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
        public List<ExcurceItem> ExcurceItems = new List<ExcurceItem>();        
        public List<ScheduleItem> ScheduleItems = new List<ScheduleItem>();
        public void FillExcurceItems()
        {
            ExcurceItems = new List<ExcurceItem>()
            {
                new ExcurceItem()
                {
                   TypeExc = "1",
                   TypeTicket = "2",
                   PriceTicket = 14.88

                }
            };
        }
    }
}
