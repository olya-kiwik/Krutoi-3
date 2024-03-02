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
using System.Drawing.Text;
using System.Diagnostics;

namespace Architecture_KC
{
    public partial class GlavForm : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private string selectedFilePath;

        private bool _isAdmin;
        public GlavForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        string conn = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
        public void SelectUC1()
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            string query = "SELECT * FROM Resurs";

            sqlConnection.Open();

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TheorUC uc1 = new TheorUC();
                    
                    //uc1.PictureBox1.Image = new Bitmap();
                    uc1.Label2.Text = reader.GetInt32(0).ToString();
                    uc1.Label1.Text = reader.GetString(1);

                    flowLayoutPanel2.Controls.Add(uc1);


                }
            }

            sqlConnection.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LodinForm lodinForm = new LodinForm();
            lodinForm.Show();
            Close();
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
            guna2Button4.Visible = _isAdmin;
            guna2Button7.Visible = _isAdmin;
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
                    SqlCommand command = new SqlCommand("Insert INTO Resurs (Teoria) values (@Teoria) ", conn);
                    command.Parameters.Add("@Teoria", SqlDbType.VarBinary).Value = File.ReadAllBytes(selectedFilePath);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SelectUC1();
        }


        private int _ClickLol = 0;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            _ClickLol++;
            if(_ClickLol == 10)
            {
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                _ClickLol = 0;
            }

        }
    }
}
