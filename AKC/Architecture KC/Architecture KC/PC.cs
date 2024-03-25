using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        
        PCQuerySql sql = new PCQuerySql();
        
        private void PC_Load(object sender, EventArgs e)
        {     
            AddBtn.Visible = _isAdmin;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            sql.SelectBox(CompComponent);
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GlavForm glavForm = new GlavForm(_isAdmin);
            glavForm.Show();
            Hide();
        }

        

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
