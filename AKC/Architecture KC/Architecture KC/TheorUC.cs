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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
            using (SqlConnection conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT File from Resurs where id_file=@id", conn);
                    command.Parameters.AddWithValue("@id", );
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
        }
    }
}
