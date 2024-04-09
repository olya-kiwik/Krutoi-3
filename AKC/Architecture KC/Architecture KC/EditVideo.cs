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

        private bool isDragging = false;
        private Point lastCursorPos;
        private bool _isAdmin;

        PCQuerySql sql = new PCQuerySql();
        public EditVideo(bool Admin)
        {
            InitializeComponent();
            _isAdmin = Admin;
        }
 

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*var up = MessageBox.Show($"Вы действительно хотите применить изменения?","Подверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //-------------------------------
            if (up == DialogResult.Yes)
            {
                
                try
                {
                    sql.EditVideo(TBName, TBLink);

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
            }*/
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

        private void EditVideo_Load(object sender, EventArgs e)
        {
            try
            {
                VideoUC uc2 = new VideoUC(_isAdmin);
                                                    
                idLabel.Text = uc2.LabelId.Text;
                TBName.Text = uc2.LabelName.Text;
                TBLink.Text = uc2.Link.Text;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
