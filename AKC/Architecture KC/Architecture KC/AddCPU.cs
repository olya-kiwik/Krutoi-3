using Guna.UI2.WinForms;
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
    public partial class AddCPU : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;

        PCQuerySql sql = new PCQuerySql();

        public AddCPU()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPos = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastCursorPos.X) + e.X,
                    (this.Location.Y - lastCursorPos.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != null && guna2ComboBox1.SelectedIndex != -1 && guna2ComboBox2.SelectedIndex != -1 && guna2TextBox2.Text != null && guna2TextBox3.Text != null && guna2TextBox4.Text != null && guna2TextBox5.Text != null && guna2TextBox6.Text != null)
            {
                var qute = MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (qute == DialogResult.Yes)
                {
                    sql.AddCPU(guna2ComboBox2, guna2ComboBox1, guna2TextBox1, guna2TextBox2, guna2TextBox3, guna2TextBox4, guna2TextBox5, guna2TextBox6);

                    var quet2 = MessageBox.Show("Добавить ещё компанент?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (quet2 == DialogResult.Yes)
                    {
                        guna2TextBox1.Text = null;
                        guna2TextBox2.Text = null;
                        guna2TextBox3.Text = null;
                        guna2TextBox4.Text = null;
                        guna2TextBox5.Text = null;
                        guna2TextBox6.Text = null;
                        guna2ComboBox1.SelectedIndex = -1;
                        guna2ComboBox2.SelectedIndex = -1;
                    }
                    else
                    {
                        Close();
                    }
                }
                else if (qute == DialogResult.No)
                    Close();
            }
            else
            {
                MessageBox.Show("Не все данные были добавлены!\nПожалуйста проверьте что все данные заполнены.", "Ошибка заполнения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
