using Guna.UI2.WinForms;
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
    public partial class TheorUC : UserControl
    {
        public TheorUC()
        {
            InitializeComponent();
        }

        public Guna2PictureBox PictureBox1
        {
            get {return guna2PictureBox1;}
            set { guna2PictureBox1 = value;}
        }

        public Label Label1
        {
            get { return label1;}
            set { label1 = value;}
        }

        public Label Label2
        {
            get { return label2; }
            set { label2 = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"SELECT Teoria from Resurs where id={label2.Text}", conn);
                   
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        byte[] filedata = (byte[])reader["Teoria"];
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Text files (*.docx)|.docx|Excel (*.xlsx)|.xlsx|PDF (*.pdf)|.pdf|All Files (*.*)|*.* ";
                        saveFileDialog.FilterIndex = 0;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, filedata);
                            MessageBox.Show($"Файл успешно загружен {saveFileDialog.RestoreDirectory}");
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
    }
}
