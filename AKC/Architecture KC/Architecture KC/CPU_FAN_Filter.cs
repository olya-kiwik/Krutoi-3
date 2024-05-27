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
        private bool _isAdmin;
        public CPU_FAN_Filter(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void CPU_FAN_Filter_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_Cooling(flowLayoutPanel1, Type, TDP, _isAdmin);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_CoolingSeek(flowLayoutPanel1, Type, TDP, _isAdmin);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectCPU_Cooling(flowLayoutPanel1, Type, TDP, _isAdmin);
            guna2Button1.Visible = false;
        }
    }
}
