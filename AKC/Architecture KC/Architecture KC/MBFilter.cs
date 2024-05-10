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
        public MBFilter()
        {
            InitializeComponent();
        }

        private void MBFilter_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMB(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMBSeek(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectMB(flowLayoutPanel1, Creator, Soket, DDR, FF, Chipset);
            guna2Button1.Visible = false;
        }
    }
}
