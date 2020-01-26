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
        public int PriceTickets 
        { 
            get => int.Parse(txtPriceTicket.Text);
            set => txtPriceTicket.Text = Convert.ToString(value);  
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
        public List<String> TypeTickets 
        {
            get => cbTypeTicket.DataSource as List<String>;
            set => cbTypeTicket.DataSource = value;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler SoldTickets
        {
            add => btnSoldTicket.Click += value;
            remove => btnSoldTicket.Click -= value;
        }
        public new void Show()
        {
            Application.Run(this);
        }

        public event EventHandler AddEx
        {
            add => btnAddExcursion.Click += value;
            remove => btnAddExcursion.Click -= value;
        }
    }
}
