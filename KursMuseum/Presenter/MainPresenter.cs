using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.Model;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        IMainForm mainView { get; set; }
        public BindingList<ExcurceItem> ExcurceItems = new BindingList<ExcurceItem>()
        {
            new ExcurceItem(){TypeExc = "1",TypeTicket="1",TimeFinish = DateTime.Now, TimeStart = DateTime.Now, PriceTicket = "15"}
        };        

        public void Run()
        {
            mainView.Show();
        }

        public MainPresenter (IMainForm view)
        {
            mainView = view;
            view.RaspEx += RaspExClick;
            view.SellForm += SellFormOpen;            
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
