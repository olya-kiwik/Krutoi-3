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
    public partial class CPUFilter : UserControl
    {
        public CPUFilter()
        {
            InitializeComponent();
        }

        public Guna2ComboBox Creator
        {
            get { return ff; }
            set { ff = value; }
        }

        public Guna2ComboBox Soket
        {
            get { return guna2ComboBox1; }
            set { guna2ComboBox1 = value; }
        }

        public Guna2ComboBox DDR
        {
            get { return guna2ComboBox2; }
            set { guna2ComboBox2 = value; }
        }

        public Guna2ComboBox TDP
        {
            get { return guna2ComboBox3; }
            set { guna2ComboBox3 = value; }
        }

        public Guna2ComboBox P_Core
        {
            get { return guna2ComboBox6; }
            set { guna2ComboBox6 = value; }
        }

    }
}
