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
        }


        private void guna2Button4_Click(object sender, EventArgs e) //Выбор файла для загрузки
        {
            AddFiles addFiles = new AddFiles();
            addFiles.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
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
