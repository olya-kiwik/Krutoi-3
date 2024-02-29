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

        public Guna2TextBox TextBox1
        {
            get { return guna2TextBox1;}
            set { guna2TextBox1 = value;}
        }
    }
}
