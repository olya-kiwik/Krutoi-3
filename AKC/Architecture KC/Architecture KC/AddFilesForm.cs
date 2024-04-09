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
using System.IO;

namespace Architecture_KC
{
    public partial class AddFiles : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private string selectedFilePath;
        PCQuerySql sql = new PCQuerySql();

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
            openFileDialog.Filter = "Word Files (*.docx)|*.docx|PowerPoint Files(*.pptx)|*.pptx|PDF Files (*.pdf)|*.pdf|Exel Files (*.xlxs)|*.xlxs|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                var name = Path.GetFileName(selectedFilePath);
                label6.Text = $"Выбран: {name}";
                guna2TextBox1.Text = name;
                MessageBox.Show($"Файл {name} выбран!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                sql.AddFile(selectedFilePath, guna2TextBox1);
                
                MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddFiles_Load(object sender, EventArgs e)
        {
            label6.Text = "Файл не выбран.";
        }
    }
}
