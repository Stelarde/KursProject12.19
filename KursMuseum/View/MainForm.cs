using KursMuseum.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursMuseum.View
{
    public partial class MainForm : Form, IMainForm
    {
        public int CountTickets 
        { 
            get => int.Parse(txtCountTickets.Text); 
            set => txtCountTickets.Text = Convert.ToString(value); 
        }
        public int BalanceTickets 
        { 
            get => int.Parse(txtBalanceTickets.Text);
            set => txtBalanceTickets.Text = Convert.ToString(value);  
        }
        public double Sum 
        { 
            get => double.Parse(txtSum.Text);
            set => txtSum.Text = Convert.ToString(value);  
        }
        /*public List<TypeTicket> TypeTickets 
        {
            get => dgvMainTable.DataSource as List<TypeTicket>;
            set => dgvMainTable.DataSource = value; 
        }*/
        /*public List<TypeTicketExcurce> TypeTicketsExcurces 
        { 
            get => dgvMainTable.DataSource as List<TypeTicketExcurce>;
            set => dgvMainTable.DataSource = value;
        }*/
        public List<ScheduleExcursionItem> ScheduleExcursionItems
        {
            get => dgvMainTable.DataSource as List<ScheduleExcursionItem>;
            set => dgvMainTable.DataSource = value;
        }
        public MainForm()
        {
            InitializeComponent();

        }
        public new void Show()
        {
            Application.Run(this);
        }

        public event EventHandler RaspEx
        {
            add => button4.Click += value;
            remove => button4.Click -= value;
        }
        public event EventHandler SellForm
        {
            add => button1.Click += value;
            remove => button1.Click -= value;
        }
    }
}
