using Amazon.DeviceFarm.Model;
using Guna.UI2.WinForms;
using Org.BouncyCastle.Asn1.X509;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Architecture_KC
{
    public partial class PC : Form
    {
        private bool _isAdmin;
        public PC(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        PCQuerySql sql = new PCQuerySql();

        public string BoxName;

        public string fff
        {
            get { return BoxName; }
            set { BoxName = value; }
        }


        private void PC_Load(object sender, EventArgs e)
        {     
            AddBtn.Visible = _isAdmin;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Companent.Controls.Clear();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GlavForm glavForm = new GlavForm(_isAdmin);
            glavForm.Show();
            Hide();
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            SelectAddComonent sac = new SelectAddComonent();
            sac.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)//Корпус
        {
            guna2PictureBox1.Image = Properties.Resources.pc_tower;
            ComponentSelect.Text = "Corpus";

            guna2PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            BoxFilter bf = new BoxFilter();
            bf.TopLevel = false;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Size = Companent.Size;
            Companent.Controls.Add(bf);
            bf.Visible = true;
        }

        private void guna2PictureBox1_MouseEnter(object sender, EventArgs e)//Корпус
        {
            guna2PictureBox1.Image = Properties.Resources.pc_tower;
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)//Корпус
        {
            if(guna2PictureBox1.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox1.Image = Properties.Resources.pc_tower_def;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)//Системная плата
        {
            guna2PictureBox2.Image = Properties.Resources.mother_board;
            ComponentSelect.Text = "MB";

            guna2PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            MBFilter mb = new MBFilter();
            mb.TopLevel = false;
            mb.FormBorderStyle = FormBorderStyle.None;
            mb.Size = Companent.Size;
            Companent.Controls.Add(mb);
            mb.Visible = true;
        }

        private void guna2PictureBox2_MouseEnter(object sender, EventArgs e)//Системная плата
        {
            guna2PictureBox2.Image = Properties.Resources.mother_board;
        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)//Системная плата
        {
            if(guna2PictureBox2.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox2.Image = Properties.Resources.mother_board_def;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)//проццессор
        {
            
            ComponentSelect.Text = "CPU";

            guna2PictureBox4.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            CPUFilter cpu = new CPUFilter();
            cpu.TopLevel = false;
            cpu.FormBorderStyle = FormBorderStyle.None;
            cpu.Size = Companent.Size;
            Companent.Controls.Add(cpu);
            cpu.Visible = true;

        }

        private void guna2PictureBox4_MouseEnter(object sender, EventArgs e)//проццессор
        {
            guna2PictureBox4.Image = Properties.Resources.cpu;
        }

        private void guna2PictureBox4_MouseLeave(object sender, EventArgs e)//проццессор
        {
            if(guna2PictureBox4.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox4.Image = Properties.Resources.cpu_def;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)//охлад процессора
        {
            guna2PictureBox3.Image = Properties.Resources.cpu_fan;
            ComponentSelect.Text = "CPU_FAN";

            guna2PictureBox3.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            CPU_FAN_Filter cpuf = new CPU_FAN_Filter();
            cpuf.TopLevel = false;
            cpuf.FormBorderStyle = FormBorderStyle.None;
            cpuf.Size = Companent.Size;
            Companent.Controls.Add(cpuf);
            cpuf.Visible = true;
        }

        private void guna2PictureBox3_MouseEnter(object sender, EventArgs e)//охлад процессора
        {
            guna2PictureBox3.Image = Properties.Resources.cpu_fan;
        }

        private void guna2PictureBox3_MouseLeave(object sender, EventArgs e)//охлад процессора
        {
            if(guna2PictureBox3.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox3.Image = Properties.Resources.cpu_fan_def;
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)//ОЗУ
        {
            guna2PictureBox8.Image = Properties.Resources.ram;
            ComponentSelect.Text = "RAM";

            guna2PictureBox8.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            FilterRAM ram = new FilterRAM();
            ram.TopLevel = false;
            ram.FormBorderStyle = FormBorderStyle.None;
            ram.Size = Companent.Size;
            Companent.Controls.Add(ram);
            ram.Visible = true;
        }

        private void guna2PictureBox8_MouseEnter(object sender, EventArgs e)//ОЗУ
        {
            guna2PictureBox8.Image = Properties.Resources.ram;
        }

        private void guna2PictureBox8_MouseLeave(object sender, EventArgs e)//ОЗУ
        {
            if(guna2PictureBox8.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox8.Image = Properties.Resources.ram_def;
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)//видеокарта
        {
            guna2PictureBox7.Image = Properties.Resources.gpu;
            ComponentSelect.Text = "GPU";

            guna2PictureBox7.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            FilterGPU gpu = new FilterGPU();
            gpu.TopLevel = false;
            gpu.FormBorderStyle = FormBorderStyle.None;
            gpu.Size = Companent.Size;
            Companent.Controls.Add(gpu);
            gpu.Visible = true;
        }

        private void guna2PictureBox7_MouseEnter(object sender, EventArgs e)//видеокарта
        {
            guna2PictureBox7.Image = Properties.Resources.gpu;
        }

        private void guna2PictureBox7_MouseLeave(object sender, EventArgs e)//видеокарта
        {
            if(guna2PictureBox7.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox7.Image = Properties.Resources.gpu_def;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)//жйский диск
        {
            guna2PictureBox6.Image = Properties.Resources.hdd;
            ComponentSelect.Text = "HDD";

            guna2PictureBox6.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox5.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            FilterSorage hdd = new FilterSorage();
            hdd.TopLevel = false;
            hdd.FormBorderStyle = FormBorderStyle.None;
            hdd.Size = Companent.Size;
            Companent.Controls.Add(hdd);
            hdd.Visible = true;
        }

        private void guna2PictureBox6_MouseEnter(object sender, EventArgs e)//жйский диск
        {
            guna2PictureBox6.Image = Properties.Resources.hdd;
        }

        private void guna2PictureBox6_MouseLeave(object sender, EventArgs e)//жйский диск
        {
            if(guna2PictureBox6.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox6.Image = Properties.Resources.hdd_def;
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)//блок питания
        {
            guna2PictureBox5.Image = Properties.Resources.power;
            ComponentSelect.Text = "power";

            guna2PictureBox5.BorderStyle = BorderStyle.FixedSingle;
            guna2PictureBox2.BorderStyle = BorderStyle.None;
            guna2PictureBox3.BorderStyle = BorderStyle.None;
            guna2PictureBox4.BorderStyle = BorderStyle.None;
            guna2PictureBox1.BorderStyle = BorderStyle.None;
            guna2PictureBox6.BorderStyle = BorderStyle.None;
            guna2PictureBox7.BorderStyle = BorderStyle.None;
            guna2PictureBox8.BorderStyle = BorderStyle.None;

            Companent.Controls.Clear();
            FilterPower w = new FilterPower();
            w.TopLevel = false;
            w.FormBorderStyle = FormBorderStyle.None;
            w.Size = Companent.Size;
            Companent.Controls.Add(w);
            w.Visible = true;
        }

        private void guna2PictureBox5_MouseEnter(object sender, EventArgs e)//блок питания
        {
            guna2PictureBox5.Image = Properties.Resources.power;
        }

        private void guna2PictureBox5_MouseLeave(object sender, EventArgs e)//блок питания
        {
            if(guna2PictureBox5.BorderStyle != BorderStyle.FixedSingle)
                guna2PictureBox5.Image = Properties.Resources.power_def;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SeeComplect_Click(object sender, EventArgs e)
        {
            SeeCompForm see = new SeeCompForm();
            see.ShowDialog();

        }
    }
}
