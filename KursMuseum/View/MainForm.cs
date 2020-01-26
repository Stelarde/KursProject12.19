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
        public double PriceTickets 
        { 
            get => double.Parse(txtPriceTicket.Text);
            set => txtPriceTicket.Text = Convert.ToString(value);  
        }
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

        public event EventHandler ChTypeTicket
        {
            add => cbTypeTicket.SelectedIndexChanged += value;
            remove => cbTypeTicket.SelectedIndexChanged -= value;
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
