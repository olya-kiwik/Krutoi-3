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

        private bool _isAdmin;
        public GlavForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
            loadingCicle.Visible = false;
            guna2TextBox1.Visible = false;
            Methods.ResetLayout1 = FLP1reset;

        }

        private void GlavForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        string conn = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
        public void SelectTheorUC1()
        {
            loadingCicle.Start();
            loadingCicle.Visible = true;
            try
            {
                
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM txtResurs";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TheorUC uc1 = new TheorUC(_isAdmin);

                        //uc1.PictureBox1.Image = new Bitmap();
                        uc1.Label2.Text = reader.GetInt32(0).ToString();
                        uc1.Label1.Text = reader.GetString(1);

                        flowLayoutPanel2.Controls.Add(uc1);


                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch(Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectVideoUC2() 
        {
            loadingCicle.Start();
            loadingCicle.Visible = true;
            try
            {

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM videoResurs";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        VideoUC uc2 = new VideoUC();

                        byte[] img = (byte[])(reader[3]);
                        MemoryStream ms = new MemoryStream(img);

                        uc2.ImageVideo.Image = Image.FromStream(ms);
                        uc2.LabelId.Text = reader.GetInt32(0).ToString();
                        uc2.LabelName.Text = reader.GetString(1);
                        uc2.Link.Text = reader.GetString(2);

                        flowLayoutPanel2.Controls.Add(uc2);

                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch (Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            var quit = MessageBox.Show("Вы действительно хотите выйти из акаунта?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                LodinForm lodinForm = new LodinForm();
                lodinForm.Show();
                Hide();
            }
            
        }

        public void FLP1reset()
        {
            flowLayoutPanel2.Controls.Clear();
            SelectTheorUC1();
        }

        public void FLP2reset()
        {
            flowLayoutPanel2.Controls.Clear();
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
            
            if(_isAdmin == true)
            {
                guna2TextBox1.Size = new System.Drawing.Size(720, 45);
            }
            else
            {
                guna2TextBox1.Size = new System.Drawing.Size(827, 45);
            }
            
        }


        private void guna2Button4_Click(object sender, EventArgs e) //Выбор файла для загрузки
        {
            AddFiles addFiles = new AddFiles();
            addFiles.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)//Лекции
        {
            label3.Text = "txtResurs";
            guna2TextBox1.Visible = true;
            guna2Button4.Visible = _isAdmin;
            FLP1reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)//Видео
        {
            label3.Text = "videoResurs";
        }

        private void searchLec_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            string conn = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand($"Select * from {label3.Text} where Name like @Searth", con);
                cmd.Parameters.AddWithValue("@Searth", (string.Format("{0}%", guna2TextBox1.Text)));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TheorUC theorUC = new TheorUC(_isAdmin);
                    //theorUC.PictureBox1.Image
                    theorUC.Label2.Text = reader.GetInt32(0).ToString();
                    theorUC.Label1.Text = reader.GetString(1);

                    flowLayoutPanel2.Controls.Add(theorUC);
                }
                reader.Close();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private int _ClickLol = 0;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            _ClickLol++;
            if(_ClickLol == 10)
            {
                Process.Start("https://www.youtube.com/watch?v=0tOXxuLcaog");
                _ClickLol = 0;
            }

        }

        
    }
}
