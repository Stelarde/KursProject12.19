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

        public void Run()
        {
            mainView.Show();            
        }

        public MainPresenter (IMainForm view, LocalStorage db)
        {
            mainView = view;
            view.RaspEx += RaspExClick;
            view.SellForm += SellFormOpen;
            //view.TypeTickets = db.TypeTickets;
            //view.TypeTicketsExcursions = db.TypeTicketExcursions;
            view.ScheduleExcursionItems = db.ScheduleExcursionItems;
        }
        private void RaspExClick(object sender, EventArgs e)
        {
            var rf = new RaspPrs(new RaspForm());
            //mainView.Sum
        }
        private void SellFormOpen(object sender, EventArgs e)
        {
            var se = new SellPrs(new SellEx());
        }
    }
}