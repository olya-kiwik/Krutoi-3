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
    public partial class VideoUC : UserControl
    {
        public VideoUC()
        {
            InitializeComponent();
        }

        public Label LabelName
        {
            get { return NameLabel; }
            set { NameLabel = value; } 
        }

        public Label LabelId
        {
            get { return labelid; }
        }

        public Label Link
        {
            get { return link; }
            set { link = value; }
        }

        public Guna2PictureBox ImageVideo
        {
            get { return imageVideo; }
            set { imageVideo = value; }
        }

        string con = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";

        private void delBt_Click(object sender, EventArgs e)
        {
            var deel = MessageBox.Show($"Вы действительно хотите удалить видео: {NameLabel.Text}?" +
                "\nПосле удаления востановить запись будет невозможно.", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deel == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(con);
                    string del = $"DELETE FROM videoResurs WHERE id={labelid.Text}";

                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(del, sqlConnection))
                    {
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
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            EditVideo editVideo = new EditVideo();
            editVideo.Show();
        }

        private void PlayBt_Click(object sender, EventArgs e)
        {

        }

        
    }
}
