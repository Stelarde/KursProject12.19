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

        public MainForm()
        {
            InitializeComponent();
            dgvMainTable.Rows.Clear();
            dgvMainTable.Columns.Clear();
            dgvMainTable.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TypeExc",
                HeaderText = "Тип экскурсии"
            });
            dgvMainTable.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TimeStart",
                HeaderText = "Дата и время начала экскурсии"
            });
            dgvMainTable.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TimeFinish",
                HeaderText = "Дата и время конца экскурсии"
            });
            dgvMainTable.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TypeTicket",
                HeaderText = "Тип билета"
            });
            dgvMainTable.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PriceTicket",
                HeaderText = "Цена билета"
            });
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
