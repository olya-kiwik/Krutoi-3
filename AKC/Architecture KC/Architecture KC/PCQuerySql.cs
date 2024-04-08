using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Architecture_KC
{
    public class PCQuerySql
    {
        string conn = @"Data Source = (localdb)\MSSqlLocalDB; Initial Catalog = AKC; Integrated Security = SSPI";

        public void SelectBox(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Box";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(1);
                        pcUC.ImageComp.Image = Properties.Resources.pc_tower;
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(2)}"+Environment.NewLine+$"Размер корпуса: {reader.GetString(3)}"+Environment.NewLine+$"Размер блока питания: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                        comboBox.Items.Add(reader.GetString(3));

                        RemoveDuplicates(comboBox);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectBoxSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            
            try
            {
                

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = $"SELECT * FROM Box where BoxSize like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.pc_tower;
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(1)}" + Environment.NewLine + $"Размер корпуса: {reader.GetString(2)}" + Environment.NewLine + $"Размер блока питания: {reader.GetString(3)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.cpu;
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        comboBox.Items.Add(reader.GetString(1));
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPUSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU where Creator like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {

                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.cpu;
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMB(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM MotherBoard";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.mother_board;
                        pcUC.labelType.Text = "Системная плата";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Сокет: {reader.GetString(1)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Чипсет: {reader.GetString(4)}" + Environment.NewLine + $"Форум-фактор: {reader.GetString(5)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        comboBox.Items.Add(reader.GetString(1));
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMBSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM MotherBoard where Socket like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.mother_board;
                        pcUC.labelType.Text = "Системная плата";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Сокет: {reader.GetString(1)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Чипсет: {reader.GetString(4)}" + Environment.NewLine + $"Форум-фактор: {reader.GetString(5)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectGPU(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM GPU";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.gpu;
                        pcUC.labelType.Text = "Видеокарта";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Кол-во памяти: {reader.GetString(1)} Гб" + Environment.NewLine + $"Тип памяти: ПDDR{reader.GetString(3)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        comboBox.Items.Add(reader.GetString(2));

                        RemoveDuplicates(comboBox);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectGPUSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM GPU where Creator like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.gpu;
                        pcUC.labelType.Text = "Видеокарта";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Кол-во памяти: {reader.GetString(1)} Гб" + Environment.NewLine + $"Тип памяти: ПDDR{reader.GetString(3)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU_Cooling(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU_Cool";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.cpu_fan;
                        pcUC.labelType.Text = "Охлаждение процессора";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(1)}" + Environment.NewLine + $"Рассеиваемая мощность(TDP): {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        comboBox.Items.Add(reader.GetString(2));
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU_CoolingSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU_Cool where TDP like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {

                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.cpu_fan;
                        pcUC.labelType.Text = "Охлаждение процессора";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(1)}" + Environment.NewLine + $"Рассеиваемая мощность(TDP): {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectRAM(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM RAM";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.ram;
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип памяти: DDR{reader.GetString(1)}" + Environment.NewLine + $"Объём памяти: {reader.GetString(2)} Гб" + Environment.NewLine + $"Тактовая частота: {reader.GetString(3)} МГц" + Environment.NewLine + $"Тайминги: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        comboBox.Items.Add(reader.GetString(1));
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectRAMSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM RAM where DDR like @Searth";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Searth", (string.Format("{0}%", comboBox.SelectedItem)));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.ram;
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип памяти: DDR{reader.GetString(1)}" + Environment.NewLine + $"Объём памяти: {reader.GetString(2)} Гб" + Environment.NewLine + $"Тактовая частота: {reader.GetString(3)} МГц" + Environment.NewLine + $"Тайминги: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectPower(FlowLayoutPanel flowLayoutPanel)
        {
            
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Power";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.power;
                        pcUC.labelType.Text = "Блок питания";
                        pcUC.TextBoxHar.Text = $"Мощность: {reader.GetString(1)} W" + Environment.NewLine + $"Форм фактор: {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectHDD(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Storage";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ImageComp.Image = Properties.Resources.hdd;
                        pcUC.labelType.Text = "Накопитель";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(2)}" + Environment.NewLine + $"Скорость вращения: {reader.GetString(1)} об/мин";

                        flowLayoutPanel.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoveDuplicates(Guna2ComboBox comboBox)
        {
            try
            {
                List<string> items = new List<string>();

                foreach (string item in comboBox.Items)
                {
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }

                comboBox.Items.Clear();
                comboBox.Items.AddRange(items.ToArray());

                
            }
            catch
            {
                
            }
        }

    }
}
