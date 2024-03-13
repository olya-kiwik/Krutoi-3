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
    public partial class PC : Form
    {
        private bool _isAdmin;
        public PC(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void PC_Load(object sender, EventArgs e)
        {

            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GlavForm glavForm = new GlavForm(_isAdmin);
            glavForm.Show();
            Hide();
        }
    }
}
