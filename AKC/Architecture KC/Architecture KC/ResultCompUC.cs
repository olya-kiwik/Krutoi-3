using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class ResultCompUC : UserControl
    {
        static PCQuerySql sql = new PCQuerySql();

        static string conect = sql.GetSqlConn();

        public ResultCompUC()
        {
            InitializeComponent();
        }

        public Guna2PictureBox pictureBox1
        {
            get { return guna2PictureBox1; }
            set { guna2PictureBox1 = value; }
        }

        public Label Label1
        {
            get { return label1; }
            set { label1 = value; }
        }

        public Label Label2
        {
            get { return label2; }
            set { label2 = value; }
        }

        public Label Label3
        {
            get { return label3; }
            set { label3 = value; }
        }

        string con = $@"Data Source = {conect}; Initial Catalog = AKC; Integrated Security = SSPI";
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"SELECT Result_comp from Prepod where id={label2.Text}", conn);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        byte[] filedata = (byte[])reader["Result_comp"];
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = label1.Text;
                        saveFileDialog.Filter = "PDF (*.pdf)|.pdf";
                        saveFileDialog.FilterIndex = 0;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, filedata);
                            MessageBox.Show($"Файл успешно загружен!", "Успех");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            var deel = MessageBox.Show($"Вы действительно хотите удалить запись: {label1.Text}?" +
                "\nПосле удаления востановить запись будет невозможно.", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deel == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string del = $"DELETE FROM Prepod WHERE id={label2.Text}";

                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(del, sqlConnection))
                    {
                        command.ExecuteReader();
                    }
                    sqlConnection.Close();

                    Methods.ResetLayout4();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
        private void TheorUC_Load(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Properties.Resources.pdf;
            
        }

    }
}
