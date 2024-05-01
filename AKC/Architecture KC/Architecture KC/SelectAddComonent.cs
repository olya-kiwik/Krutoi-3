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
    public partial class SelectAddComonent : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;

        AddBox addBox = new AddBox();
        AddCPU addCPU = new AddCPU();
        AddCPU_Colling addCPU_Colling = new AddCPU_Colling();
        AddGPU addGPU = new AddGPU();
        AddMotherBoard addMotherBoard = new AddMotherBoard();



        public SelectAddComonent()
        {
            TopMost = true;
            InitializeComponent();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (guna2ComboBox1.SelectedIndex)
                {
                    case -1:

                        MessageBox.Show("Необходимо выбрать параметр!", "Ошибка!");
                        return;

                    case 0://Корпус

                        addBox.ShowDialog();
                        break;

                    case 1://Процессор

                        addCPU.ShowDialog();
                        break;

                    case 2://Охлаждение процессора

                        addCPU_Colling.ShowDialog();
                        break;

                    case 3://Системная плата

                        addMotherBoard.ShowDialog();
                        break;

                    case 4://Видеокарта

                        addGPU.ShowDialog();
                        break;

                    case 5://Оперативная память


                        break;

                    case 6://Блок питания


                        break;

                    case 7://Хранилище


                        break;

                }
                Close();
            }
            catch
            {

            }
            
        }
    }
}









