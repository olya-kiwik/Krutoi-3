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
using Guna.UI2.WinForms;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;

namespace Architecture_KC
{
    public partial class TestUC : UserControl
    {
        private bool _isAdmin;
        static PCQuerySql sql = new PCQuerySql();

        static string conect = sql.GetSqlConn();
        public TestUC(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        public Guna2PictureBox PictureBox1
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

        public Label Link
        {
            get { return labelLink; }
            set { labelLink = value; }
        }

        string con = $@"Data Source = {conect}; Initial Catalog = AKC; Integrated Security = SSPI";
        


        private void Del_Click(object sender, EventArgs e)
        {
            var deel = MessageBox.Show($"Вы действительно хотите удалить запись: {label1.Text}?" +
                "\nПосле удаления востановить запись будет невозможно.", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deel == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string del = $"DELETE FROM Test WHERE id={label2.Text}";

                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(del, sqlConnection))
                    {
                        command.ExecuteReader();
                    }
                    sqlConnection.Close();

                    Methods.ResetLayout3();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
        private void TestUC_Load(object sender, EventArgs e)
        {
            delBt.Visible = _isAdmin;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(con);
                string query = $"SELECT Link FROM Test where id like {label2.Text}";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Process.Start($"{reader["Link"].ToString()}");
                    }

                }
                sqlConnection.Close();

                //Methods.WebViewLoad(labelLink.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
