using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class AddVideo : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private string selectedFilePath;
        public AddVideo()
        {
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

        string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO videoResurs (Name, Link) values (@Name, @Link)", conn);
                    command.Parameters.AddWithValue("@Name", TBName.Text);
                    command.Parameters.AddWithValue("@Link", TBLink.Text);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                    Methods.ResetLayout1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Methods.ResetLayout2();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
