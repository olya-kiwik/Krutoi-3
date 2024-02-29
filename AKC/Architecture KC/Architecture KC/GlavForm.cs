using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.IO;
using Architecture_KC.Properties;
using System.Data.SqlClient;

namespace Architecture_KC
{
    public partial class GlavForm : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private string selectedFilePath;
        public GlavForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        
        private void GlavForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aKCDataSet1.Resurs". При необходимости она может быть перемещена или удалена.
            this.resursTableAdapter.Fill(this.aKCDataSet1.Resurs);


            for (int i = 0; i < resursDataGridView.Rows.Count - 1; i++)
            {
                TheorUC uc1 = new TheorUC();
                flowLayoutPanel1.Controls.Add(uc1);

                //uc1.PictureBox1.Image = Image.FromFile();
                uc1.Label1.Text = Convert.ToString(resursDataGridView[1, i].Value);

            }
        }

        private void resursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aKCDataSet1);

        }

        private void resursBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.resursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aKCDataSet1);

        }

        private void guna2Button4_Click(object sender, EventArgs e) //Выбор файла для загрузки
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files (*.docx)|*.docx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"Файл {openFileDialog.FileName} выбран!", "Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e) // Добавление файла в бд
        {
            string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
            
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Insert INTO Resurs (File) values (@Teoria) ", conn);
                    command.Parameters.Add("@Teoria", SqlDbType.VarBinary).Value = File.ReadAllBytes(selectedFilePath);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
