using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.IO;
using Architecture_KC.Properties;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;

namespace Architecture_KC
{
    public partial class GlavForm : Form
    {

        private bool isDragging = false;
        private Point lastCursorPos;

        static PCQuerySql sql = new PCQuerySql();
        private bool _isAdmin;
        static string conect = sql.GetSqlConn();
        public GlavForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
            loadingCicle.Visible = false;
            guna2TextBox1.Visible = false;
            Methods.ResetLayout1 = FLP1reset;
            Methods.ResetLayout2 = FLP2reset;
            Methods.ResetLayout3 = FLP3reset;
            Methods.ResetLayout4 = FLP4reset;
            
        }

        private void GlavForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        string conn = $@"Data Source = {conect}; Initial Catalog = AKC; Integrated Security = SSPI";

        public void SelectTheorUC1()
        {
            loadingCicle.Start();
            loadingCicle.Visible = true;
            try
            {
                
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM txtResurs";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TheorUC uc1 = new TheorUC(_isAdmin);

                        uc1.Label2.Text = reader.GetInt32(0).ToString();
                        uc1.Label1.Text = reader.GetString(1);

                        flowLayoutPanel2.Controls.Add(uc1);

                        
                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch(Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectVideoUC2() 
        {
            loadingCicle.Start();
            loadingCicle.Visible = true;
            try
            {

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM videoResurs";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        VideoUC uc2 = new VideoUC(_isAdmin);

                        uc2.LabelId.Text = reader.GetInt32(0).ToString();
                        uc2.LabelName.Text = reader.GetString(1);
                        uc2.Link.Text = reader.GetString(2);

                        flowLayoutPanel2.Controls.Add(uc2);

                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch (Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectTestUC3()
        {
            loadingCicle.Start();
            loadingCicle.Visible = true;
            try
            {

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Test";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TestUC uc3 = new TestUC(_isAdmin);

                        uc3.Label2.Text = reader.GetInt32(0).ToString();
                        uc3.Label1.Text = reader.GetString(1);
                        uc3.Link.Text = reader.GetString(2);

                        flowLayoutPanel2.Controls.Add(uc3);

                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch (Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectResultUC4()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Prepod";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ResultCompUC uc4 = new ResultCompUC();

                        uc4.Label2.Text = reader.GetInt32(0).ToString();
                        uc4.Label1.Text = reader.GetString(2);
                        uc4.Label3.Text = reader.GetString(1);
                        uc4.DateTimePicker1.Text = Convert.ToString(reader.GetDateTime(4));
                        
                        flowLayoutPanel2.Controls.Add(uc4);

                    }
                }
                sqlConnection.Close();
                loadingCicle.Stop();
                loadingCicle.Visible = false;
            }
            catch (Exception ex)
            {
                loadingCicle.Stop();
                loadingCicle.Visible = false;
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            var quit = MessageBox.Show("Вы действительно хотите выйти из акаунта?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                LodinForm lodinForm = new LodinForm();
                lodinForm.Show();
                Hide();
            }
            
        }

        public void FLP1reset()//перезагрузка теории
        {
            flowLayoutPanel2.Controls.Clear();
            SelectTheorUC1();
        }

        public void FLP2reset()//перезагрузка видео
        {
            flowLayoutPanel2.Controls.Clear();
            SelectVideoUC2();
        }

        public void FLP3reset()//перезагрузка теста
        {
            flowLayoutPanel2.Controls.Clear();
            SelectTestUC3();
        }

        public void FLP4reset()//перезагрузка сборок студентов
        {
            flowLayoutPanel2.Controls.Clear();
            SelectResultUC4();
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

        
        private void GlavForm_Load(object sender, EventArgs e)
        {
            if(_isAdmin == true)
            {
                guna2TextBox1.Size = new System.Drawing.Size(758, 45);
                guna2Button8.Visible = true;
            }
            else
            {
                guna2TextBox1.Size = new System.Drawing.Size(865, 45);
                guna2Button8.Visible = false;
            }

            //------------------------Корпус--------------------------------------
            string filePathBox = @"Box.txt";
            string[] linesBox = File.ReadAllLines(filePathBox);
            int[] BoxlinesToDelete = { 1, 2, 3, 4, 5 ,6};

            using (StreamWriter sw = new StreamWriter(filePathBox))
            {
                for (int i = 0; i < linesBox.Length; i++)
                {
                    if (!BoxlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesBox[i]);
                    }
                }
            }
            //--------------------------Процессор-------------------------------------
            string filePathCPU = @"CPU.txt";
            string[] linesCPU = File.ReadAllLines(filePathCPU);
            int[] CPUlinesToDelete = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};

            using (StreamWriter sw = new StreamWriter(filePathCPU))
            {
                for (int i = 0; i < linesCPU.Length; i++)
                {
                    if (!CPUlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesCPU[i]);
                    }
                }
            }
            //-------------------------Сист. плата------------------------------------
            string filePathMB = @"MB.txt";
            string[] linesMB = File.ReadAllLines(filePathMB);
            int[] MBlinesToDelete = { 1, 2, 3, 4, 5, 6, 7 , 8};

            using (StreamWriter sw = new StreamWriter(filePathMB))
            {
                for (int i = 0; i < linesMB.Length; i++)
                {
                    if (!MBlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesMB[i]);
                    }
                }
            }
            //-------------------------Видеокарта--------------------------------------
            string filePathGPU = @"GPU.txt";
            string[] linesGPU = File.ReadAllLines(filePathGPU);
            int[] GPUlinesToDelete = { 1, 2, 3, 4, 5, 6 , 7};

            using (StreamWriter sw = new StreamWriter(filePathGPU))
            {
                for (int i = 0; i < linesGPU.Length; i++)
                {
                    if (!GPUlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesGPU[i]);
                    }
                }
            }
            //----------------------------Охлаждение процессора---------------------------------
            string filePathCPU_Cool = @"CPU_COOL.txt";
            string[] linesCPU_Cool = File.ReadAllLines(filePathCPU_Cool);
            int[] CPU_CoolLinesToDelete = { 1, 2, 3, 4, 5 };

            using (StreamWriter sw = new StreamWriter(filePathCPU_Cool))
            {
                for (int i = 0; i < linesCPU_Cool.Length; i++)
                {
                    if (!CPU_CoolLinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesCPU_Cool[i]);
                    }
                }
            }
            //------------------------Оперативная память-----------------------------------
            string filePathRAM = @"RAM.txt";
            string[] linesRAM = File.ReadAllLines(filePathRAM);
            int[] RAMlinesToDelete = { 1, 2, 3, 4, 5, 6 , 7};

            using (StreamWriter sw = new StreamWriter(filePathRAM))
            {
                for (int i = 0; i < linesRAM.Length; i++)
                {
                    if (!RAMlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesRAM[i]);
                    }
                }
            }
            //----------------------------Блок питания-----------------------------------
            string filePathPower = @"Power.txt";
            string[] linesPower = File.ReadAllLines(filePathPower);
            int[] PowerlinesToDelete = { 1, 2, 3, 4 , 5};

            using (StreamWriter sw = new StreamWriter(filePathPower))
            {
                for (int i = 0; i < linesPower.Length; i++)
                {
                    if (!PowerlinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesPower[i]);
                    }
                }
            }
            //--------------------------Хранилище-----------------------------------
            string filePathStorage = @"Storage.txt";
            string[] linesStorage = File.ReadAllLines(filePathStorage);
            int[] StoragelinesToDelete = { 1, 2, 3, 4, 5 };

            using (StreamWriter sw = new StreamWriter(filePathStorage))
            {
                for (int i = 0; i < linesStorage.Length; i++)
                {
                    if (!StoragelinesToDelete.Contains(i + 1))
                    {
                        sw.WriteLine(linesStorage[i]);
                    }
                }
            }
            //--------------------------------------------------------------------
        }

        private void guna2Button4_Click(object sender, EventArgs e) //Выбор файла для загрузки
        {
            if (guna2Button4.Text == "Добавить видео")
            {
                AddVideo addVideo = new AddVideo();
                addVideo.ShowDialog();
            }
            else if (guna2Button4.Text == "Добавить файл")
            {
                AddFiles addFiles = new AddFiles();
                addFiles.ShowDialog();
            }
            else if (guna2Button4.Text == "Добавить Тест")
            {
                AddTest addTest = new AddTest();
                addTest.ShowDialog();
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)//Лекции
        {
            if (flowLayoutPanel2.Visible == false)
            {
                flowLayoutPanel2.Visible = true;
            }

            guna2Button4.Text = "Добавить файл";
            label3.Text = "txtResurs";
            guna2TextBox1.Visible = true;
            guna2Button4.Visible = _isAdmin;
            FLP1reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)//Видео
        {
            if (flowLayoutPanel2.Visible == false)
            {
                flowLayoutPanel2.Visible = true;
            }
            guna2Button4.Text = "Добавить видео";
            label3.Text = "videoResurs";
            guna2TextBox1.Visible = true;
            guna2Button4.Visible = _isAdmin;
            FLP2reset();
        }

        private void guna2Button3_Click(object sender, EventArgs e)//Test
        {
            if (flowLayoutPanel2.Visible == false)
            {
                flowLayoutPanel2.Visible = true;
            }
            guna2Button4.Visible = _isAdmin;
            guna2Button4.Text = "Добавить Тест";
            label3.Text = "Test";
            guna2TextBox1.Visible = true;
            FLP3reset();

            
        }

        private void guna2Button8_Click(object sender, EventArgs e)//Сборки
        {
            if (flowLayoutPanel2.Visible == false)
            {
                flowLayoutPanel2.Visible = true;
            }
            label3.Text = "Prepod";
            guna2TextBox1.Visible = true;
            FLP4reset();
        }

        private void guna2Button6_Click(object sender, EventArgs e)//Сборка
        {
            PC pc = new PC(_isAdmin);
            pc.Show();
            Hide();
        }

        private void searchLec_TextChanged(object sender, EventArgs e)//Поиск
        {
            flowLayoutPanel2.Controls.Clear();
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand($"Select * from {label3.Text} where Name like @Searth", con);

                    cmd.Parameters.AddWithValue("@Searth", (string.Format("{0}%", guna2TextBox1.Text)));
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (label3.Text == "txtResurs")
                    {

                        while (reader.Read())
                        {

                            TheorUC theorUC = new TheorUC(_isAdmin);

                            theorUC.Label2.Text = reader.GetInt32(0).ToString();
                            theorUC.Label1.Text = reader.GetString(1);

                            flowLayoutPanel2.Controls.Add(theorUC);
                        }

                    }
                    else if (label3.Text == "videoResurs")
                    {

                        while (reader.Read())
                        {
                            VideoUC videoUC = new VideoUC(_isAdmin);

                            videoUC.LabelName.Text = reader.GetString(1);
                            videoUC.LabelId.Text = reader.GetInt32(0).ToString();

                            flowLayoutPanel2.Controls.Add(videoUC);
                        }

                    }

                    reader.Close();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    SqlCommand cmd = new SqlCommand($"Select * from {label3.Text} where FIO_stud like @SearthFIO or _Group like @SearthG", con);

                    cmd.Parameters.AddWithValue("@SearthFIO", (string.Format("{0}%", guna2TextBox1.Text)));
                    cmd.Parameters.AddWithValue("@SearthG", (string.Format("{0}%", guna2TextBox1.Text)));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ResultCompUC RCUC = new ResultCompUC();

                        RCUC.Label1.Text = reader.GetString(2);
                        RCUC.Label3.Text = reader.GetString(1);
                        RCUC.Label2.Text = reader.GetInt32(0).ToString();

                        flowLayoutPanel2.Controls.Add(RCUC);
                    }

                    reader.Close();
                    cmd.ExecuteNonQuery();
                }
                
                

                
                con.Close();
            }
        }


        private int _ClickLol = 0;
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            _ClickLol++;
            if(_ClickLol == 10)
            {
                Process.Start("https://www.youtube.com/watch?v=0tOXxuLcaog");
                _ClickLol = 0;
            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
