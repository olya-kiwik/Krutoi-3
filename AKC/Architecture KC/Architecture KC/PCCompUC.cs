using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture_KC
{
    public partial class PCCompUC : UserControl
    {
        static bool isAdmin;

        PCQuerySql sql;
        PC pc = new PC(isAdmin:isAdmin);
        
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

        public Label ID
        {
            get { return IDBox; }
            set { IDBox = value; }
        }

        private void PCCompUC_Load(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None; // возвращаем стандартный стиль границ
            NameComp.ForeColor = Color.FromArgb(184, 184, 184); // цвет текста стандартный
            BackColor = Color.Transparent; // возвращаем стандартный фон
            groupBox1.ForeColor = Color.LightGray;
        }

        private void SelectBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SelectBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (labelType.Text)
                {
                    //--------------------------------------------------------------------
                    case ("Корпус"):
                        string filePathBox = @"Box.txt";
                        string[] linesBox = File.ReadAllLines(filePathBox);
                        int[] BoxlinesToDelete = { 1, 2, 3, 4 };

                        string dataBox = $"Название корпуса: {labelName.Text}\nХарактеристики\n{haracter.Text}";
                        
                        using (StreamWriter sw = new StreamWriter(filePathBox))
                        {
                            for (int i = 0; i < linesBox.Length; i++)
                            {
                                if (!BoxlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesBox[i]);
                                }
                            }
                            
                            sw.Write(dataBox);
                        }
                            break;
                    //--------------------------------------------------------------------
                    case ("Процессор"):
                        string filePathCPU = @"CPU.txt";
                        string[] linesCPU = File.ReadAllLines(filePathCPU);
                        int[] CPUlinesToDelete = { 1, 2, 3, 4, 5, 6, 7, 8 };

                        string dataCPU = $"Название процессора: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathCPU))
                        {
                            for (int i = 0; i < linesCPU.Length; i++)
                            {
                                if (!CPUlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesCPU[i]);
                                }
                            }

                            sw.Write(dataCPU);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Системная плата"):
                        string filePathMB = @"MB.txt";
                        string[] linesMB = File.ReadAllLines(filePathMB);
                        int[] MBlinesToDelete = { 1, 2, 3, 4, 5, 6};

                        string dataMB = $"Название системной платы: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathMB))
                        {
                            for (int i = 0; i < linesMB.Length; i++)
                            {
                                if (!MBlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesMB[i]);
                                }
                            }

                            sw.Write(dataMB);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Видеокарта"):
                        string filePathGPU = @"GPU.txt";
                        string[] linesGPU = File.ReadAllLines(filePathGPU);
                        int[] GPUlinesToDelete = { 1, 2, 3, 4, 5};

                        string dataGPU = $"Название видеокарты: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathGPU))
                        {
                            for (int i = 0; i < linesGPU.Length; i++)
                            {
                                if (!GPUlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesGPU[i]);
                                }
                            }

                            sw.Write(dataGPU);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Охлаждение процессора"):
                        string filePathCPU_Cool = @"CPU_COOL.txt";
                        string[] linesCPU_Cool = File.ReadAllLines(filePathCPU_Cool);
                        int[] CPU_CoolLinesToDelete = { 1, 2, 3};

                        string dataCPU_Cool = $"Название кулера: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathCPU_Cool))
                        {
                            for (int i = 0; i < linesCPU_Cool.Length; i++)
                            {
                                if (!CPU_CoolLinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesCPU_Cool[i]);
                                }
                            }

                            sw.Write(dataCPU_Cool);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Оперативная память"):
                        string filePathRAM = @"RAM.txt";
                        string[] linesRAM = File.ReadAllLines(filePathRAM);
                        int[] RAMlinesToDelete = { 1, 2, 3, 4, 5};

                        string dataRAM = $"Название оперативной памяти: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathRAM))
                        {
                            for (int i = 0; i < linesRAM.Length; i++)
                            {
                                if (!RAMlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesRAM[i]);
                                }
                            }

                            sw.Write(dataRAM);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Блок питания"):
                        string filePathPower = @"Power.txt";
                        string[] linesPower = File.ReadAllLines(filePathPower);
                        int[] PowerlinesToDelete = { 1, 2, 3 };

                        string dataPower = $"Название блока питания: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathPower))
                        {
                            for (int i = 0; i < linesPower.Length; i++)
                            {
                                if (!PowerlinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesPower[i]);
                                }
                            }

                            sw.Write(dataPower);
                        }
                        break;
                    //--------------------------------------------------------------------
                    case ("Накопитель"):
                        string filePathStorage = @"Storage.txt";
                        string[] linesStorage = File.ReadAllLines(filePathStorage);
                        int[] StoragelinesToDelete = { 1, 2, 3 };

                        string dataStorage = $"Название накопителя: {labelName.Text}\nХарактеристики\n{haracter.Text}";

                        using (StreamWriter sw = new StreamWriter(filePathStorage))
                        {
                            for (int i = 0; i < linesStorage.Length; i++)
                            {
                                if (!StoragelinesToDelete.Contains(i + 1))
                                {
                                    sw.WriteLine(linesStorage[i]);
                                }
                            }

                            sw.Write(dataStorage);
                        }
                        break;
                    //--------------------------------------------------------------------
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
