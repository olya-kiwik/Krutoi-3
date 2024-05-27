using System;
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
    public partial class MBFilter : Form
    {
        PCQuerySql sql = new PCQuerySql();
        private bool _isAdmin;
        public MBFilter(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void MBFilter_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMB(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset, _isAdmin);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMBSeek(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset, _isAdmin);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMB(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset, _isAdmin);
            guna2Button1.Visible = false;
        }
    }
}
