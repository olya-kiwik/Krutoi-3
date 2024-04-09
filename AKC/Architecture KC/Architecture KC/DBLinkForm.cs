using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class DBLinkForm : Form
    {
        PCQuerySql sql = new PCQuerySql();

        public DBLinkForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://flectone.ru/sql-imya-servera.html");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2link.Text != null)
            {
                sql.SetSqlConn(guna2link.Text);
                Close();
            }
            else
                MessageBox.Show($"Поле {label1.Text} пустое!\nПожалуйста заполните поле {label1.Text}","Ошибка!");
                
        }
    }
}
