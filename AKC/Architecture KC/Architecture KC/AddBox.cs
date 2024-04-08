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
    public partial class AddBox : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        public AddBox()
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

        private void Add()
        {
            string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO Box (Name, FormFactorMatherBoar, BoxSize, FormFactorPower) values (@Name, @FormFactorMatherBoard, @BpxSize, @FormFactorPower)", conn);
                    command.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
                    command.Parameters.AddWithValue("@FormFactorMatherBoard", guna2ComboBox3.Text);
                    command.Parameters.AddWithValue("@BpxSize", guna2ComboBox1.Text);
                    command.Parameters.AddWithValue("@FormFactorPower", guna2ComboBox2.Text);
                    command.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != null && guna2ComboBox3.SelectedIndex != -1 && guna2ComboBox1.SelectedIndex != -1 && guna2ComboBox2.SelectedIndex != -1)
            {
                var qute = MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (qute == DialogResult.Yes)
                {
                    Add();

                    var quet2 = MessageBox.Show("Добавить ещё компанент?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (quet2 == DialogResult.Yes)
                    {
                        guna2TextBox1.Text = null;
                        guna2ComboBox1.SelectedIndex = -1;
                        guna2ComboBox2.SelectedIndex = -1;
                        guna2ComboBox3.SelectedIndex = -1;

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
