using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    class RaspPrs
    {
        IRaspForm raspForm;
        public RaspPrs(IRaspForm RF)
        {
            raspForm = RF;
            RF.AddEx += AddExClick;
            raspForm.Show();
        }
        private void AddExClick(object sender, EventArgs e)
        {
            var ex = new CreatedPrs(new CreatedEx());
        }
    }   
}