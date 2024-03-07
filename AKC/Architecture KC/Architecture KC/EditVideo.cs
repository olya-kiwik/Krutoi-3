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
    public partial class EditVideo : Form
    {
        private bool _isAdmin;
        public EditVideo(bool Admin)
        {
            InitializeComponent();
            _isAdmin = Admin;
        }
 

        string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var up = MessageBox.Show($"Вы действительно хотите применить изменения?","Подверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (up == DialogResult.Yes)
            {
                VideoUC uc1 = new VideoUC(_isAdmin);
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string update = $"Update videoResurs set Name = @Name, Link = @Link WHERE id={uc1.LabelId.Text}";

                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(update, sqlConnection))
                    {
                        /*if (TBName.Text != null && TBLink.Text != null)
                        {*/
                            command.Parameters.AddWithValue("@Name", TBName.Text);
                            command.Parameters.AddWithValue("@Link", TBLink.Text);
                        //}
                        /*else if (TBName.Text != null && TBLink.Text == null)
                        {
                            command.Parameters.AddWithValue("@Name", TBName.Text);
                                                    }
                        else if (TBLink.Text != null && TBName.Text == null)
                        {
                            command.Parameters.AddWithValue("@Link", TBLink.Text);
                        }
                        else if(TBLink.Text == null && TBName.Text == null)
                        {
                            MessageBox.Show("При подтверждении изменений, оба поля не могут быть пустыми!","Ошбка");
                        }
                        */


                        command.ExecuteReader();
                    }
                    sqlConnection.Close();
                    Close();
                    Methods.ResetLayout2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (up == DialogResult.No)
            {
                Close();
            }
        }

        private void EditVideo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
