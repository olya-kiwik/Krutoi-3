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
    public partial class CPU_FAN_Filter : Form
    {
        PCQuerySql sql = new PCQuerySql();

        public CPU_FAN_Filter()
        {
            InitializeComponent();
        }

        private void CPU_FAN_Filter_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_Cooling(flowLayoutPanel1, Type, TDP);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_CoolingSeek(flowLayoutPanel1, Type, TDP);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_Cooling(flowLayoutPanel1, Type, TDP);
            guna2Button1.Visible = false;
        }
    }
}
