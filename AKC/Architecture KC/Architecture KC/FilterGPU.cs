using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class FilterGPU : Form
    {
        PCQuerySql sql = new PCQuerySql();

        public FilterGPU()
        {
            InitializeComponent();
        }

        private void FilterGPU_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectGPU(flowLayoutPanel1, Creator, GB, GDDR, GPUSize);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectGPUSeek(flowLayoutPanel1, Creator, GB, GDDR, GPUSize);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectGPU(flowLayoutPanel1, Creator, GB, GDDR, GPUSize);
            guna2Button1.Visible = false;
        }
    }
}
