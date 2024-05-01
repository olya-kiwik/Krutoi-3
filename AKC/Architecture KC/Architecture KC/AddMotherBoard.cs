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
    public partial class AddMotherBoard : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;

        PCQuerySql sql = new PCQuerySql();

        public AddMotherBoard()
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
            if (name.Text != null && formFactor.SelectedIndex != -1 && socket.Text != null && chipset.Text != null && ddr.Text != null && creator.Text != null)
            {
                var qute = MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (qute == DialogResult.Yes)
                {
                    sql.AddMB(name, socket, creator, ddr, chipset, formFactor);

                    var quet2 = MessageBox.Show("Добавить ещё компанент?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (quet2 == DialogResult.Yes)
                    {
                        name.Text = null;
                        chipset.Text = null;
                        creator.Text = null;
                        socket.Text = null;
                        ddr.Text = null;
                        formFactor.SelectedIndex = -1;

                    }
                    else if (quet2 == DialogResult.No)
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
