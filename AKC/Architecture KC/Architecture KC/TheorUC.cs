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
        private bool _isAdmin;
        static PCQuerySql sql = new PCQuerySql();

        static string conect = sql.GetSqlConn();
        public TheorUC(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
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
        
        string con = $@"Data Source = {conect}; Initial Catalog = AKC; Integrated Security = SSPI";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"SELECT Teoria from txtResurs where id={label2.Text}", conn);
                   
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        byte[] filedata = (byte[])reader["Teoria"];
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = label1.Text;
                        saveFileDialog.Filter = "Text files (*.docx)|.docx|Excel (*.xlsx)|.xlsx|PDF (*.pdf)|.pdf|All Files (*.*)|*.* ";
                        saveFileDialog.FilterIndex = 0;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, filedata);
                            MessageBox.Show($"Файл успешно загружен!","Успех");
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
                    string del = $"DELETE FROM txtResurs WHERE id={label2.Text}";

                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(del, sqlConnection))
                    {
                        command.ExecuteReader();
                    }
                    sqlConnection.Close();

                    Methods.ResetLayout1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }           
        }
        private void TheorUC_Load(object sender, EventArgs e)
        {
            delBt.Visible = _isAdmin;
            string str = label1.Text;
            if (str.Substring(str.Length - 5) == ".docx")
                guna2PictureBox1.Image = Properties.Resources.word;
            else if(str.Substring(str.Length - 4) == ".pdf")
                guna2PictureBox1.Image = Properties.Resources.pdf;
            else if(str.Substring(str.Length - 5) == ".xlsx")
                guna2PictureBox1.Image = Properties.Resources.excel;
            else if(str.Substring(str.Length - 5) == ".pptx")
                guna2PictureBox1.Image = Properties.Resources.powerpoint;
        }
    }
}
