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

        public EditVideo()
        {
            InitializeComponent();
        }

        string imgLoc = "";

        string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            VideoUC uc1 = new VideoUC();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(con);
                string update = $"Update videoResurs set Name = @Name, Link = @Link, Image = @Image WHERE id={uc1.LabelId.Text}";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(update, sqlConnection))
                {

                    command.Parameters.AddWithValue("@Name",TBName.Text);
                    command.Parameters.AddWithValue("@Link", TBLink.Text);
                    command.Parameters.AddWithValue("@Image",imagePB.Image);


                    command.ExecuteReader();
                }
                sqlConnection.Close();

                Methods.ResetLayout2();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditVideo_Load(object sender, EventArgs e)
        {
            VideoUC uc1 = new VideoUC();
            TBName.Text = uc1.LabelName.Text;
            TBLink.Text = uc1.Link.Text;
        }

        private void imagePB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files png (*.png)|*.png|Files jpg(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dialog.FileName.ToString();
                imagePB.ImageLocation = imgLoc;
            }
        }
    }
}
