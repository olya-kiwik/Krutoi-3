﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class FilterPower : Form
    {
        PCQuerySql sql = new PCQuerySql();
        private bool _isAdmin;
        public FilterPower(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void FilterPower_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectPower(flowLayoutPanel1, W, FF, _isAdmin);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectPowerSeek(flowLayoutPanel1, W, FF, _isAdmin);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectPower(flowLayoutPanel1, W, FF, _isAdmin);
            guna2Button1.Visible = false;
        }
    }
}
