using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;
using KursMuseum.Model;
using KursMuseum.DAL;

namespace KursMuseum.Presenter
{
    public class ChangeExPrs
    {
        IChangeEx changeEx;
        ScheduleExcursionItem scheduleExcursionItem = new ScheduleExcursionItem();

        public ChangeExPrs(IChangeEx ChEx)
        {
            changeEx = ChEx;
            changeEx.Show();
            ChEx.ChangeExcursion += ChengeExcursionClick;
            //changeEx.NameExcursion = 
        }

        private void ChengeExcursionClick(object sender, EventArgs e)
        {
            scheduleExcursionItem.TypeExcursion = changeEx.NameExcursion;
            scheduleExcursionItem.TimeStart = changeEx.TimeStartExcursion;
            scheduleExcursionItem.TimeFinish = changeEx.TimeFinishExcursion;
            scheduleExcursionItem.Venue = changeEx.VenueExcursion;
            scheduleExcursionItem.TicketsLeft = changeEx.QuantityTicketsExcursion;
            scheduleExcursionItem.InitialCost = changeEx.StartPriceTicketExcursion;
            UnitOfWork unitOfWork = new UnitOfWork();
            //unitOfWork.RepositoryScheduleExcursionItem.Create(scheduleExcursionItem);
            changeEx.Close();
        }
    }
}
