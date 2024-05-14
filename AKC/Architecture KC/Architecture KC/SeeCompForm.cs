using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class SeeCompForm : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;

        public SeeCompForm()
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

        private void SeeCompForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("Box.txt");

                // Запись первой строки в Label
                label2.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox1.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("CPU.txt");

                // Запись первой строки в Label
                label3.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox2.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("MB.txt");

                // Запись первой строки в Label
                label4.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox3.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("RAM.txt");

                // Запись первой строки в Label
                label5.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox4.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("RAM.txt");

                // Запись первой строки в Label
                label5.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox4.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("Power.txt");

                // Запись первой строки в Label
                label6.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox5.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("CPU_COOL.txt");

                // Запись первой строки в Label
                label7.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox6.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("GPU.txt");

                // Запись первой строки в Label
                label8.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox7.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines("Storage.txt");

                // Запись первой строки в Label
                label9.Text = lines[1];

                // Запись остальных строк в TextBox
                for (int i = 2; i < lines.Length; i++)
                {
                    textBox8.Text += lines[i] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
