using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    class SellPrs
    {
        ISellEx sellEx;
        public SellPrs(ISellEx SE)
        {
            sellEx = SE;
            sellEx.Show();
        }
    }
}
