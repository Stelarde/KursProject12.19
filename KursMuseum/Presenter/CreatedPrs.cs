using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursMuseum.View;

namespace KursMuseum.Presenter
{
    class CreatedPrs
    {
        ICreatedEx createdEx;
        public CreatedPrs(ICreatedEx CE)
        {
            createdEx = CE;
            createdEx.Show();
        }
    }
}
