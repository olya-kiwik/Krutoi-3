﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Architecture_KC
{
    public partial class AddFiles : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private string selectedFilePath;
        public AddFiles()
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files (*.docx)|*.docx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"Файл {openFileDialog.FileName} выбран!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
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
                    SqlCommand command = new SqlCommand($"Insert INTO txtResurs (Teoria, Name) values (@Teoria,@Name)", conn);
                    command.Parameters.Add("@Teoria", SqlDbType.VarBinary).Value = File.ReadAllBytes(selectedFilePath);
                    command.Parameters.AddWithValue("@Name", guna2TextBox1.Text);
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }
    }
}
