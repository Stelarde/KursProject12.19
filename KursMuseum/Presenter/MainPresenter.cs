using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.DAL;
using KursMuseum.Model;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        IMainForm mainView { get; set; }
        double PriceTicket;

        public void Run()
        {
            mainView.Show();            
        }
        public MainPresenter (IMainForm view, LocalStorage db)
        {
            mainView = view;
            view.AddEx += AddExClick;
            view.SoldTickets += SoldTicketsClick;
            view.TypeTicket += TypeTicketChanged;
            view.MainTable += ExcursionChoice;
            List<string> TypeTicket = new List<string> {db.TypeTickets[0].TicketName, db.TypeTickets[1].TicketName, db.TypeTickets[2].TicketName};
            view.ScheduleExcursionItems = db.ScheduleExcursionItems;
            view.TypeTickets = TypeTicket;
        }

        private void ExcursionChoice(object sender, EventArgs e)
        {
            PriceTicket = mainView.SelectMainTale;
        }

        private void TypeTicketChanged(object sender, EventArgs e)
        {
            if (mainView.SelectTypeTckets == 0 | mainView.SelectTypeTckets == 2)
            {
                mainView.PriceTickets = PriceTicket * 1.1;

            }
            else
            {
                mainView.PriceTickets = PriceTicket * 1.3;
            }
        }

        private void AddExClick(object sender, EventArgs e)
        {
            var rf = new CreatedPrs(new CreatedEx());
        }
        private void SoldTicketsClick(object sender, EventArgs e)
        {
            var sf = new SellPrs(new SellForm(), new DAL.LocalStorage());
        }
    }
}