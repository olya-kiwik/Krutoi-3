using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class PCCompUC : UserControl
    {
        public PCCompUC()
        {
            InitializeComponent();
        }
                
        public Label labelName
        {
            get { return NameComp; }
            set { NameComp = value; }
        }

        public TextBox TextBoxHar
        {
            get { return haracter; }
            set { haracter = value; }
        }

        public Label labelType
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public Guna2PictureBox ImageComp
        {
            get { return guna2PictureBox1; }
            set { guna2PictureBox1 = value; }
        }

        private void PCCompUC_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle; // устанавливаем новый стиль границ
            NameComp.ForeColor = Color.Black; // цвет текста чёрный
            BackColor = Color.LightGray; // меняем фон при наведении
            groupBox1.ForeColor = Color.Black;

        }

        private void PCCompUC_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None; // возвращаем стандартный стиль границ
            NameComp.ForeColor = Color.FromArgb(184,184,184); // цвет текста стандартный
            BackColor = Color.Transparent; // возвращаем стандартный фон
            groupBox1.ForeColor = Color.LightGray;
        }

        private void PCCompUC_Load(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None; // возвращаем стандартный стиль границ
            NameComp.ForeColor = Color.FromArgb(184, 184, 184); // цвет текста стандартный
            BackColor = Color.Transparent; // возвращаем стандартный фон
            groupBox1.ForeColor = Color.LightGray;
        }

        private void NameComp_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
