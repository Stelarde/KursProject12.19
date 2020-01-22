﻿using System;
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
    public partial class RaspForm : Form, IRaspForm
    {
        public RaspForm()
        {
            InitializeComponent();            
        }
        public event EventHandler AddEx
        {
            add => Button1.Click += value;
            remove => Button1.Click -= value;
        }
    }
}
