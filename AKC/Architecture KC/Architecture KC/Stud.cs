using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.pdf.parser;
using Amazon.ElasticTranscoder.Model;
using Amazon.Lambda;
using System.Data.SqlClient;

namespace Architecture_KC
{
    public partial class Stud : Form
    {
        private static bool _isAdmin;

        private bool isDragging = false;
        private Point lastCursorPos;

        PCQuerySql sql = new PCQuerySql();

        public Stud()
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

        

        public static string TranslateToEnglish(string input)
        {
            string[] cyrillic = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я",
                            "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };

            string[] latin = { "a", "b", "v", "g", "d", "e", "e", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", "ts", "ch", "sh", "shch", "", "y", "", "e", "yu", "ya",
                            "A", "B", "V", "G", "D", "E", "E", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "H", "Ts", "Ch", "Sh", "Shch", "", "Y", "", "E", "Yu", "Ya" };

            for (int i = 0; i < cyrillic.Length; i++)
            {
                input = input.Replace(cyrillic[i], latin[i]);
            }


            return input;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string filePathBox = "Box.txt";
            string filePathCPU = "CPU.txt";
            string filePathRAM = "RAM.txt";
            string filePathGPU = "GPU.txt";
            string filePathStorage = "Storage.txt";
            string filePathMB = "MB.txt";
            string filePathCPU_Colling = "CPU_COOL.txt";
            string filePathPower = "Power.txt";

            Document document = new Document();

            if (lastName.Text != "" && studName.Text != "" && Group.Text != "")
            {
                try
                {
                    //Установка шрифта для PDF файла
                    string ttf = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                    var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    var fontTitle = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD);

                    PdfWriter.GetInstance(document, new FileStream($@"{TranslateToEnglish(lastName.Text)}_{TranslateToEnglish(studName.Text)}_{TranslateToEnglish(middleName.Text)}_{TranslateToEnglish(Group.Text)}.pdf", FileMode.Create));

                    document.Open();

                    // Чтение данных из файла
                    string[] linesBox = File.ReadAllLines(filePathBox);
                    string[] linesCPU = File.ReadAllLines(filePathCPU);
                    string[] linesRAM = File.ReadAllLines(filePathRAM);
                    string[] linesGPU = File.ReadAllLines(filePathGPU);
                    string[] linesStorage = File.ReadAllLines(filePathStorage);
                    string[] linesMB = File.ReadAllLines(filePathMB);
                    string[] linesCPU_Cooling = File.ReadAllLines(filePathCPU_Colling);
                    string[] linesPower = File.ReadAllLines(filePathPower);

                    // Вывод данных в PDF
                    Paragraph PDFName = new Paragraph($"{Group.Text}\n{lastName.Text} {studName.Text} {middleName.Text}\n\nЗадание: {PC.Quat}\n\n", fontTitle);
                    document.Add(PDFName);

                    foreach (string line in linesBox)
                    {
                        Paragraph box = new Paragraph(line, font);
                        document.Add(box);
                    }

                    foreach (string line in linesCPU)
                    {
                        Paragraph CPU = new Paragraph(line, font);
                        document.Add(CPU);
                    }

                    foreach (string line in linesRAM)
                    {
                        Paragraph RAM = new Paragraph(line, font);
                        document.Add(RAM);
                    }

                    foreach (string line in linesCPU_Cooling)
                    {
                        Paragraph CC = new Paragraph(line, font);
                        document.Add(CC);
                    }

                    foreach (string line in linesGPU)
                    {
                        Paragraph GPU = new Paragraph(line, font);
                        document.Add(GPU);
                    }

                    foreach (string line in linesMB)
                    {
                        Paragraph MB = new Paragraph(line, font);
                        document.Add(MB);
                    }

                    foreach (string line in linesPower)
                    {
                        Paragraph Power = new Paragraph(line, font);
                        document.Add(Power);
                    }

                    foreach (string line in linesStorage)
                    {
                        Paragraph Storage = new Paragraph(line, font);
                        document.Add(Storage);
                    }

                    document.Close();

                    string studFIO = $"{lastName.Text} {studName.Text} {middleName.Text}";

                    DateTime dateTime = DateTime.Now;

                    if (guna2CheckBox1.Checked == true)
                    {
                        sql.AddResultStud(Environment.CurrentDirectory + $@"\{TranslateToEnglish(lastName.Text)}_{TranslateToEnglish(studName.Text)}_{TranslateToEnglish(middleName.Text)}_{TranslateToEnglish(Group.Text)}.pdf", studFIO, Group.Text, dateTime);
                    }

                    Close();

                    File.Delete($@"{TranslateToEnglish(lastName.Text)}_{TranslateToEnglish(studName.Text)}_{TranslateToEnglish(middleName.Text)}_{TranslateToEnglish(Group.Text)}.pdf");

                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                lastName.BorderColor = Color.Red;
                studName.BorderColor = Color.Red;
                Group.BorderColor = Color.Red;
            }
            
        }
    }
}
