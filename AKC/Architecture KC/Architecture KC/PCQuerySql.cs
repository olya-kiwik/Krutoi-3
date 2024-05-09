using Amazon.Runtime.Internal.Util;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Architecture_KC
{
    public class PCQuerySql
    {
        private bool _isAdmin;
        
        static string sqlConn = ConfigurationManager.AppSettings["dbCon"];

        public string GetSqlConn()
        {
            return sqlConn;
        }

        public void SetSqlConn(string value)
        {
            sqlConn = value;
        }

        string conn = $@"Data Source = {sqlConn}; Initial Catalog = AKC; Integrated Security = SSPI";

        public void SelectBox(FlowLayoutPanel flowLayoutPanel, FlowLayoutPanel _filter)
        {
            try
            {
                BoxFolter boxFolter = new BoxFolter();
                boxFolter.FFMB.Items.Clear();
                boxFolter.BoxSize.Items.Clear();
                boxFolter.FFP.Items.Clear();

                _filter.Controls.Add(boxFolter);

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
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(2)}"+Environment.NewLine+$"Размер корпуса: {reader.GetString(3)}"+Environment.NewLine+$"Размер блока питания: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        boxFolter.FFMB.Items.Add(reader.GetString(2));
                        boxFolter.BoxSize.Items.Add(reader.GetString(3));
                        boxFolter.FFP.Items.Add(reader.GetString(4));

                        RemoveDuplicates(boxFolter.FFMB);
                        RemoveDuplicates(boxFolter.BoxSize);
                        RemoveDuplicates(boxFolter.FFP);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectBoxSeek(FlowLayoutPanel flowLayoutPanel)
        {            
            try
            {
                BoxFolter boxFolter = new BoxFolter();
                
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = $"SELECT * FROM Box where FormFactorMatherBoar like @SearthFFMB and BoxSize like @SearthBoxSize and FormFactorPower like @SearthFFP";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthFFMB", (string.Format("{0}%", boxFolter.FFMB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthBoxSize", (string.Format("{0}%", boxFolter.BoxSize.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthFFP", (string.Format("{0}%", boxFolter.FFP.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(1);
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(2)}" + Environment.NewLine + $"Размер корпуса: {reader.GetString(3)}" + Environment.NewLine + $"Размер блока питания: {reader.GetString(4)}";

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

        public void SelectCPU(FlowLayoutPanel companent, FlowLayoutPanel _filter)
        {
            try
            {
                CPUFilter filter = new CPUFilter();
                filter.Creator.Items.Clear();
                filter.Soket.Items.Clear();
                filter.DDR.Items.Clear();
                filter.TDP.Items.Clear();
                filter.P_Core.Items.Clear();

                _filter.Controls.Add(filter);

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
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        companent.Controls.Add(pcUC);

                        filter.Creator.Items.Add(reader.GetString(1));
                        filter.Soket.Items.Add(reader.GetString(2));
                        filter.DDR.Items.Add(reader.GetString(3));
                        filter.TDP.Items.Add(reader.GetString(4));
                        filter.P_Core.Items.Add(reader.GetString(6));

                        RemoveDuplicates(filter.Creator);
                        RemoveDuplicates(filter.Soket);
                        RemoveDuplicates(filter.DDR);
                        RemoveDuplicates(filter.TDP);
                        RemoveDuplicates(filter.P_Core);
                    }
                    
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPUSeek(FlowLayoutPanel companent)
        {
            try
            {
                CPUFilter filter = new CPUFilter();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU where Creator like @SearthCreator and @SearthSoket and @SearthDDR and @SearthTDP and @SearthP_Core";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", filter.Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSoket", (string.Format("{0}%", filter.Soket.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", filter.DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthTDP", (string.Format("{0}%", filter.TDP.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthP_Core", (string.Format("{0}%", filter.P_Core.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        companent.Controls.Add(pcUC);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMB(FlowLayoutPanel companent, FlowLayoutPanel _filter)
        {
            FilterMB filterMB = new FilterMB();
            filterMB.Creator.Items.Clear();
            filterMB.Soket.Items.Clear();
            filterMB.DDR.Items.Clear();
            filterMB.FF.Items.Clear();
            filterMB.Chipset.Items.Clear();

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
                        pcUC.labelType.Text = "Системная плата";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Сокет: {reader.GetString(1)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Чипсет: {reader.GetString(4)}" + Environment.NewLine + $"Форум-фактор: {reader.GetString(5)}";

                        companent.Controls.Add(pcUC);

                        filterMB.Creator.Items.Add(reader.GetString(2));
                        filterMB.Soket.Items.Add(reader.GetString(1));
                        filterMB.DDR.Items.Add(reader.GetString(3));
                        filterMB.FF.Items.Add(reader.GetString(5));
                        filterMB.Chipset.Items.Add(reader.GetString(4));

                        RemoveDuplicates(filterMB.Creator);
                        RemoveDuplicates(filterMB.Soket);
                        RemoveDuplicates(filterMB.DDR);
                        RemoveDuplicates(filterMB.FF);
                        RemoveDuplicates(filterMB.Chipset);
                    }
                    _filter.Controls.Add(filterMB);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMBSeek(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                FilterMB filterMB = new FilterMB();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM MotherBoard where Socket like @SearthCreator and @SearthSoket and @SearthDDR and @SearthFF and @SearthChipset";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", filterMB.Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSoket", (string.Format("{0}%", filterMB.Soket.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", filterMB.DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthFF", (string.Format("{0}%", filterMB.FF.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthChipset", (string.Format("{0}%", filterMB.Chipset.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
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

        public void SelectGPU(FlowLayoutPanel companent, FlowLayoutPanel _filter)
        {
            FilterGPU filterGPU = new FilterGPU();
            filterGPU.Creator.Items.Clear();
            filterGPU.GB.Items.Clear();
            filterGPU.GDDR.Items.Clear();
            filterGPU.GPUSize.Items.Clear();

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
                        pcUC.labelType.Text = "Видеокарта";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Кол-во памяти: {reader.GetString(1)} Гб" + Environment.NewLine + $"Тип памяти: GDDR{reader.GetString(3)}" + Environment.NewLine + $"Длинна видеокарты:{reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        filterGPU.Creator.Items.Add(reader.GetString(2));
                        filterGPU.GB.Items.Add(reader.GetString(1));
                        filterGPU.GDDR.Items.Add(reader.GetString(3));
                        filterGPU.GPUSize.Items.Add(reader.GetString(4));

                        RemoveDuplicates(filterGPU.Creator);
                        RemoveDuplicates(filterGPU.GB);
                        RemoveDuplicates(filterGPU.GDDR);
                        RemoveDuplicates(filterGPU.GPUSize);
                    }
                    _filter.Controls.Add(filterGPU);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectGPUSeek(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                FilterGPU filterGPU = new FilterGPU();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM GPU where Creator like @SearthCreator and @SearthGB and @SearthGDDR and @SearthSize";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", filterGPU.Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGB", (string.Format("{0}%", filterGPU.GB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGDDR", (string.Format("{0}%", filterGPU.GDDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSize", (string.Format("{0}%", filterGPU.GPUSize.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
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

        public void SelectCPU_Cooling(FlowLayoutPanel flowLayoutPanel, FlowLayoutPanel _filter)
        {
            CPU_FAN_Filter cff = new CPU_FAN_Filter();

            cff.Type.Items.Clear();
            cff.TDP.Items.Clear();

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
                        pcUC.labelType.Text = "Охлаждение процессора";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(1)}" + Environment.NewLine + $"Рассеиваемая мощность(TDP): {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        cff.Type.Items.Add(reader.GetString(1));
                        cff.TDP.Items.Add(reader.GetString(2));

                        RemoveDuplicates(cff.Type);
                        RemoveDuplicates(cff.TDP);
                    }
                    _filter.Controls.Add(cff);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU_CoolingSeek(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                CPU_FAN_Filter cff = new CPU_FAN_Filter();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU_Cool where TDP like @SearthType and @SearthTDP";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {

                    command.Parameters.AddWithValue("@SearthType", (string.Format("{0}%", cff.Type.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthTDP", (string.Format("{0}%", cff.TDP.SelectedItem)));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
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

        public void SelectRAM(FlowLayoutPanel companent, FlowLayoutPanel _filter)
        {
            FilterRAM filterRAM = new FilterRAM();

            filterRAM.DDR.Items.Clear();
            filterRAM.GB.Items.Clear();
            filterRAM.MGHz.Items.Clear();
            filterRAM.Times.Items.Clear();

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
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип памяти: DDR{reader.GetString(1)}" + Environment.NewLine + $"Объём памяти: {reader.GetString(2)} Гб" + Environment.NewLine + $"Тактовая частота: {reader.GetString(3)} МГц" + Environment.NewLine + $"Тайминги: {reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        filterRAM.DDR.Items.Add(reader.GetString(1));
                        filterRAM.GB.Items.Add(reader.GetString(2));
                        filterRAM.MGHz.Items.Add(reader.GetString(3));
                        filterRAM.Times.Items.Add(reader.GetString(4));

                        RemoveDuplicates(filterRAM.DDR);
                        RemoveDuplicates(filterRAM.GB);
                        RemoveDuplicates(filterRAM.MGHz);
                        RemoveDuplicates(filterRAM.Times);
                    }

                    _filter.Controls.Add(filterRAM);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectRAMSeek(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                FilterRAM filterRAM = new FilterRAM();

                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM RAM where DDR like @SearthDDR and @SearthGB and @SearthMGHz and @SearthCL";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", filterRAM.DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGB", (string.Format("{0}%", filterRAM.GB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthMGHz", (string.Format("{0}%", filterRAM.MGHz.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthCL", (string.Format("{0}%", filterRAM.Times.SelectedItem)));
                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
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
                        pcUC.labelType.Text = "Накопитель";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(2)}" + Environment.NewLine + $"Скорость записи: {reader.GetString(1)} мб/сек";

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

        public void AddBox(Guna2ComboBox cb1, Guna2ComboBox cb2, Guna2ComboBox cb3, Guna2TextBox tb1)
        {

            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO Box (Name, FormFactorMatherBoar, BoxSize, FormFactorPower) values (@Name, @FormFactorMatherBoard, @BpxSize, @FormFactorPower)", con);
                    command.Parameters.AddWithValue("@Name", tb1.Text);
                    command.Parameters.AddWithValue("@FormFactorMatherBoard", cb3.Text);
                    command.Parameters.AddWithValue("@BpxSize", cb1.Text);
                    command.Parameters.AddWithValue("@FormFactorPower", cb2.Text);
                    command.ExecuteNonQuery();
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        public void AddCPU(Guna2ComboBox ddr, Guna2ComboBox creator, Guna2TextBox name, Guna2TextBox socket, Guna2TextBox tdp, Guna2TextBox max_ddr, Guna2TextBox powerCore, Guna2TextBox energyCore)
        {

            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO CPU (Name, Creator, Socket, DDR, TDP, Max_DDR, P_Core, E_Core) values " +
                        "(@Name, @Creator, @Socket, @DDR, @TDP, @Max_DDR, @P_Core, @E_Core)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Creator", creator.Text);
                    command.Parameters.AddWithValue("@Socket", socket.Text);
                    command.Parameters.AddWithValue("@DDR", ddr.Text);
                    command.Parameters.AddWithValue("@TDP", tdp.Text);
                    command.Parameters.AddWithValue("@Max_DDR", max_ddr.Text);
                    command.Parameters.AddWithValue("@P_Core", powerCore.Text);
                    command.Parameters.AddWithValue("@E_Core", energyCore.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        public void AddCPU_Cool(Guna2TextBox name, Guna2TextBox type, Guna2TextBox tdp)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO CPU_Cool (Name, Type, TDP) values (@Name, @Type, @TDP)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Type", type.Text);
                    command.Parameters.AddWithValue("@TDP", tdp.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void AddGPU(Guna2TextBox name, Guna2TextBox gb, Guna2ComboBox creator, Guna2TextBox typeMemory, Guna2TextBox size)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO GPU (Name, GB, Creator, TypeMemory, Size) values (@Name, @GB, @Creator, @TypeMemory, @Size)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@GB", gb.Text);
                    command.Parameters.AddWithValue("@Creator", creator.Text);
                    command.Parameters.AddWithValue("@TypeMemory", typeMemory.Text);
                    command.Parameters.AddWithValue("@Size", size.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void AddMB(Guna2TextBox name, Guna2TextBox socket, Guna2TextBox creator, Guna2TextBox ddr, Guna2TextBox chipset, Guna2ComboBox formFactor)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO MotherBoard (Name, Socket, Creator, DDR, ChipSet, FormFactor) values (@Name, @Socket, @Creator, @DDR, @ChipSet, @FormFactor)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Socket", socket.Text);
                    command.Parameters.AddWithValue("@Creator", creator.Text);
                    command.Parameters.AddWithValue("@DDR", ddr.Text);
                    command.Parameters.AddWithValue("@ChipSet", chipset.Text);
                    command.Parameters.AddWithValue("@FormFactor", formFactor.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void AddStorage(Guna2TextBox name, Guna2TextBox speed, Guna2ComboBox type)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO Storage (Name, Speed, Type) values (@Name, @Speed, @Type)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Speed", speed.Text);
                    command.Parameters.AddWithValue("@Type", type.Text);
                    
                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void AddRAM(Guna2TextBox name, Guna2TextBox ddr, Guna2TextBox GB, Guna2TextBox mghz, Guna2TextBox times)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO RAM (Name, DDR, GB, MGHz, Times) values (@Name, @DDR, @GB, @MGHz, @Times)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@DDR", ddr.Text);
                    command.Parameters.AddWithValue("@GB", GB.Text);
                    command.Parameters.AddWithValue("@MGHz", mghz.Text);
                    command.Parameters.AddWithValue("@Times", times.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void AddPower(Guna2TextBox name, Guna2TextBox power, Guna2ComboBox formfactor)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand($"Insert INTO Power (Name, [Power(W)], FormFactor) values (@Name, @Power, @FormFactor)", con);

                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Power", power.Text);
                    command.Parameters.AddWithValue("@FormFactor", formfactor.Text);

                    command.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении данных:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void AddFile(string selectedFilePath, Guna2TextBox tb1)
        {

            using (SqlConnection con = new SqlConnection(conn))
            {
              
                con.Open();
                SqlCommand command = new SqlCommand($"Insert INTO txtResurs (Teoria, Name) values (@Teoria,@Name)", con);
                command.Parameters.Add("@Teoria", SqlDbType.VarBinary).Value = File.ReadAllBytes(selectedFilePath);
                command.Parameters.AddWithValue("@Name", tb1.Text);
                command.ExecuteNonQuery();
                con.Close();

                Methods.ResetLayout1();
                
            }
        }

        public void AddTest(Guna2TextBox TBName, Guna2TextBox TBLink)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
             
                con.Open();
                SqlCommand command = new SqlCommand($"Insert INTO Test (Name, Link) values (@Name, @Link)", con);
                command.Parameters.AddWithValue("@Name", TBName.Text);
                command.Parameters.AddWithValue("@Link", TBLink.Text);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);          

                Methods.ResetLayout3();
            }
        }

        public void AddVideo(Guna2TextBox TBName, Guna2TextBox TBLink)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                
                con.Open();
                SqlCommand command = new SqlCommand($"Insert INTO videoResurs (Name, Link) values (@Name, @Link)", con);
                command.Parameters.AddWithValue("@Name", TBName.Text);
                command.Parameters.AddWithValue("@Link", TBLink.Text);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                Methods.ResetLayout1();              
                Methods.ResetLayout2();
            }
        }

        

    }
}
