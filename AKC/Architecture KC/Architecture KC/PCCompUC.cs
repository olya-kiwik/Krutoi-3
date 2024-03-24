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

        public Label labelId
        {
            get { return LabalId; }
            set { LabalId = value; }
        }

        public Label labelName
        {
            get { return NameComp; }
            set { NameComp = value; }
        }

        public Label labelTable
        {
            get { return TableName; }
            set { TableName = value; }
        }

        private void PCCompUC_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle; // устанавливаем новый стиль границ
            this.BackColor = Color.LightGray; // меняем фон при наведении
        }

        private void PCCompUC_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None; // возвращаем стандартный стиль границ
            this.BackColor = Color.Transparent; // возвращаем стандартный фон
        }

        private void PCCompUC_Load(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None; //стандартный стиль границ
        }
    }
}
