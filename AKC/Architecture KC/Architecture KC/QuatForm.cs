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
    public partial class QuatForm : Form
    {
        public QuatForm()
        {
            TopMost = true;
            InitializeComponent();
        }

        PCQuerySql sql = new PCQuerySql();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sql.AddQuestion(guna2Question.Text);
            MessageBox.Show($"Задание '{guna2Question.Text}', успешно добавленио!", "Добавление задания");
            Close();
        }
    }
}
