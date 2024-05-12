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
    public partial class FilterSorage : Form
    {
        PCQuerySql sql = new PCQuerySql();

        public FilterSorage()
        {
            InitializeComponent();
        }

        private void FilterSorage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectHDD(flowLayoutPanel1);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectStorageSeek(flowLayoutPanel1, Speed, Type);
            guna2Button1.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sql.SelectHDD(flowLayoutPanel1);
            guna2Button1.Visible = false;
        }
    }
}
