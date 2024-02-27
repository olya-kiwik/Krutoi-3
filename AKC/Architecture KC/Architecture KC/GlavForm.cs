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

namespace Architecture_KC
{
    public partial class GlavForm : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
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
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = $@"{docPath}\Arch";
            string[] files = Directory.GetFiles(path);

            MessageBox.Show("Number of files in the folder: " + files.Length);

            /*//FileInfo fileInfo = new FileInfo(files);
            for (int i = 0; i < files.Length; i++)
            {
                TheorUC uc1 = new TheorUC();
                flowLayoutPanel1.Controls.Add(uc1);


                uc1.PictureBox1.Image = Image.FromFile();
                uc1.Label1.Text = Convert.ToString();
                uc1.TextBox1.Text = Convert.ToString();

            }*/
        }
    }
}
