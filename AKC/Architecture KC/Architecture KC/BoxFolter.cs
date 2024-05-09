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
    public partial class BoxFolter : UserControl
    {
        public BoxFolter()
        {
            InitializeComponent();
        }

        public Guna2ComboBox FFMB
        {
            get { return ff; }
            set { ff = value; }
        }

        public Guna2ComboBox BoxSize
        {
            get { return guna2ComboBox1; }
            set { guna2ComboBox1 = value; }
        }

        public Guna2ComboBox FFP
        {
            get { return guna2ComboBox2; }
            set { guna2ComboBox2 = value; }
        }
    }
}
