﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Architecture_KC
{
    public partial class LodinForm : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        public LodinForm()
        {
            InitializeComponent();

            this.guna2parol.AutoSize = false;
            this.guna2log.Size = new Size(this.guna2log.Size.Width, 51);
        }

        public void Login()
        {
            if (guna2log.Text == "admin" && guna2parol.Text == "1234")
            {
                GlavForm form1 = new GlavForm();
                form1.Show();
                Hide();

            }
            else if (guna2log.Text == "stud" && guna2parol.Text == "1234")
            {
                GlavForm form1 = new GlavForm();
                form1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Не успешный вход!");
            }

            bufer mybufer = new bufer();
            mybufer.log(guna2log.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login();
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

        private void guna2Button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}