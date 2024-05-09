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
    public partial class CPU_FAN_Filter : UserControl
    {
        public CPU_FAN_Filter()
        {
            InitializeComponent();
        }

        public Guna2ComboBox Type
        {
            get { return ff; }
            set { ff = value; }
        }

        public Guna2ComboBox TDP
        {
            get { return guna2ComboBox1; }
            set { guna2ComboBox1 = value; }
        }
    }
}
