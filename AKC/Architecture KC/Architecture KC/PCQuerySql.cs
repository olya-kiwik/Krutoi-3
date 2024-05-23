using Amazon.Runtime.Internal.Util;
using Guna.UI2.WinForms;
using iTextSharp.xmp.impl;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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

        string conn = $@"Data Source = {sqlConn}; Initial Catalog = AKC; Integrated Security = SSPI";

        public void SelectBox(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox FFMB, Guna2ComboBox BoxSize, Guna2ComboBox FFP)
        {
            try
            {                
                FFMB.Items.Clear();
                BoxSize.Items.Clear();
                FFP.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(0));
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(2)}"+Environment.NewLine+$"Размер корпуса: {reader.GetString(3)}"+Environment.NewLine+$"Размер блока питания: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        FFMB.Items.Add(reader.GetString(2));
                        BoxSize.Items.Add(reader.GetString(3));
                        FFP.Items.Add(reader.GetString(4));

                        RemoveDuplicates(FFMB);
                        RemoveDuplicates(BoxSize);
                        RemoveDuplicates(FFP);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectBoxSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox FFMB, Guna2ComboBox BoxSize, Guna2ComboBox FFP)
        {            
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = $"SELECT * FROM Box where FormFactorMatherBoar like @SearthFFMB and BoxSize like @SearthBoxSize and FormFactorPower like @SearthFFP";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthFFMB", (string.Format("{0}%", FFMB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthBoxSize", (string.Format("{0}%", BoxSize.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthFFP", (string.Format("{0}%", FFP.SelectedItem)));

                    FFMB.Items.Clear();
                    BoxSize.Items.Clear();
                    FFP.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(1);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(0));
                        pcUC.labelType.Text = "Корпус";
                        pcUC.TextBoxHar.Text = $"Размер системной платы: {reader.GetString(2)}" + Environment.NewLine + $"Размер корпуса: {reader.GetString(3)}" + Environment.NewLine + $"Размер блока питания: {reader.GetString(4)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        FFMB.Items.Add(reader.GetString(2));
                        BoxSize.Items.Add(reader.GetString(3));
                        FFP.Items.Add(reader.GetString(4));

                        RemoveDuplicates(FFMB);
                        RemoveDuplicates(BoxSize);
                        RemoveDuplicates(FFP);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox Soket, Guna2ComboBox DDR, Guna2ComboBox TDP, Guna2ComboBox P_Core)
        {
            try
            {
                Creator.Items.Clear();
                Soket.Items.Clear();
                DDR.Items.Clear();
                TDP.Items.Clear();
                P_Core.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(8));
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: {reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(1));
                        Soket.Items.Add(reader.GetString(2));
                        DDR.Items.Add(reader.GetString(3));
                        TDP.Items.Add(reader.GetString(4));
                        P_Core.Items.Add(reader.GetString(6));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(Soket);
                        RemoveDuplicates(DDR);
                        RemoveDuplicates(TDP);
                        RemoveDuplicates(P_Core);
                    }
                    
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPUSeek(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox Soket, Guna2ComboBox DDR, Guna2ComboBox TDP, Guna2ComboBox P_Core)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU where Creator like @SearthCreator and Socket like @SearthSoket and DDR like @SearthDDR and TDP like @SearthTDP and P_Core like @SearthP_Core";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSoket", (string.Format("{0}%", Soket.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthTDP", (string.Format("{0}%", TDP.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthP_Core", (string.Format("{0}%", P_Core.SelectedItem)));

                    Creator.Items.Clear();
                    Soket.Items.Clear();
                    DDR.Items.Clear();
                    TDP.Items.Clear();
                    P_Core.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(8));
                        pcUC.labelType.Text = "Процессор";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(1)}" + Environment.NewLine + $"Сокет: {reader.GetString(2)}" + Environment.NewLine + $"Тип памяти: {reader.GetString(3)}" + Environment.NewLine + $"Тепловыделение(TDP): {reader.GetString(4)} Вт" + Environment.NewLine + $"Максидальное кол-во памяти: {reader.GetString(5)} Гб" + Environment.NewLine + $"Кол-во производительных ядер: {reader.GetString(6)}" + Environment.NewLine + $"Кол-во энергоэффективных ядер: {reader.GetString(7)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(1));
                        Soket.Items.Add(reader.GetString(2));
                        DDR.Items.Add(reader.GetString(3));
                        TDP.Items.Add(reader.GetString(4));
                        P_Core.Items.Add(reader.GetString(6));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(Soket);
                        RemoveDuplicates(DDR);
                        RemoveDuplicates(TDP);
                        RemoveDuplicates(P_Core);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMB(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox Soket, Guna2ComboBox DDR, Guna2ComboBox FF, Guna2ComboBox Chipset)
        {
            
            Creator.Items.Clear();
            Soket.Items.Clear();
            DDR.Items.Clear();
            FF.Items.Clear();
            Chipset.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(6));
                        pcUC.labelType.Text = "Системная плата";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Сокет: {reader.GetString(1)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Чипсет: {reader.GetString(4)}" + Environment.NewLine + $"Форум-фактор: {reader.GetString(5)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(2));
                        Soket.Items.Add(reader.GetString(1));
                        DDR.Items.Add(reader.GetString(3));
                        FF.Items.Add(reader.GetString(5));
                        Chipset.Items.Add(reader.GetString(4));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(Soket);
                        RemoveDuplicates(DDR);
                        RemoveDuplicates(FF);
                        RemoveDuplicates(Chipset);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectMBSeek(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox Soket, Guna2ComboBox DDR, Guna2ComboBox FF, Guna2ComboBox Chipset)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM MotherBoard where Socket like @SearthSoket and Creator like @SearthCreator and DDR like @SearthDDR and ChipSet like @SearthChipset and FormFactor like @SearthFF";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSoket", (string.Format("{0}%", Soket.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthFF", (string.Format("{0}%", FF.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthChipset", (string.Format("{0}%", Chipset.SelectedItem)));

                    Creator.Items.Clear();
                    Soket.Items.Clear();
                    DDR.Items.Clear();
                    FF.Items.Clear();
                    Chipset.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(6));
                        pcUC.labelType.Text = "Системная плата";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Сокет: {reader.GetString(1)}" + Environment.NewLine + $"Тип памяти: DDR{reader.GetString(3)}" + Environment.NewLine + $"Чипсет: {reader.GetString(4)}" + Environment.NewLine + $"Форум-фактор: {reader.GetString(5)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(2));
                        Soket.Items.Add(reader.GetString(1));
                        DDR.Items.Add(reader.GetString(3));
                        FF.Items.Add(reader.GetString(5));
                        Chipset.Items.Add(reader.GetString(4));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(Soket);
                        RemoveDuplicates(DDR);
                        RemoveDuplicates(FF);
                        RemoveDuplicates(Chipset);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectGPU(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox GB, Guna2ComboBox GDDR, Guna2ComboBox GPUSize)
        {
            Creator.Items.Clear();
            GB.Items.Clear();
            GDDR.Items.Clear();
            GPUSize.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Видеокарта";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Кол-во памяти: {reader.GetString(1)} Гб" + Environment.NewLine + $"Тип памяти: GDDR{reader.GetString(3)}" + Environment.NewLine + $"Длинна видеокарты:{reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(2));
                        GB.Items.Add(reader.GetString(1));
                        GDDR.Items.Add(reader.GetString(3));
                        GPUSize.Items.Add(reader.GetString(4));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(GB);
                        RemoveDuplicates(GDDR);
                        RemoveDuplicates(GPUSize);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectGPUSeek(FlowLayoutPanel companent, Guna2ComboBox Creator, Guna2ComboBox GB, Guna2ComboBox GDDR, Guna2ComboBox GPUSize)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM GPU where GB like @SearthGB and Creator like @SearthCreator and TypeMemory like @SearthGDDR and Size like @SearthSize";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthCreator", (string.Format("{0}%", Creator.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGB", (string.Format("{0}%", GB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGDDR", (string.Format("{0}%", GDDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthSize", (string.Format("{0}%", GPUSize.SelectedItem)));

                    Creator.Items.Clear();
                    GB.Items.Clear();
                    GDDR.Items.Clear();
                    GPUSize.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Видеокарта";
                        pcUC.TextBoxHar.Text = $"Произодитель: {reader.GetString(2)}" + Environment.NewLine + $"Кол-во памяти: {reader.GetString(1)} Гб" + Environment.NewLine + $"Тип памяти: GDDR{reader.GetString(3)}" + Environment.NewLine + $"Длинна видеокарты:{reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        Creator.Items.Add(reader.GetString(2));
                        GB.Items.Add(reader.GetString(1));
                        GDDR.Items.Add(reader.GetString(3));
                        GPUSize.Items.Add(reader.GetString(4));

                        RemoveDuplicates(Creator);
                        RemoveDuplicates(GB);
                        RemoveDuplicates(GDDR);
                        RemoveDuplicates(GPUSize);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU_Cooling(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox Type, Guna2ComboBox TDP)
        {
            Type.Items.Clear();
            TDP.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(3));
                        pcUC.labelType.Text = "Охлаждение процессора";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(1)}" + Environment.NewLine + $"Рассеиваемая мощность(TDP): {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        Type.Items.Add(reader.GetString(1));
                        TDP.Items.Add(reader.GetString(2));

                        RemoveDuplicates(Type);
                        RemoveDuplicates(TDP);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectCPU_CoolingSeek(FlowLayoutPanel flowLayoutPanel, Guna2ComboBox Type, Guna2ComboBox TDP)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM CPU_Cool where Type like @SearthType and TDP like @SearthTDP";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {

                    command.Parameters.AddWithValue("@SearthType", (string.Format("{0}%", Type.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthTDP", (string.Format("{0}%", TDP.SelectedItem)));

                    Type.Items.Clear();
                    TDP.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(3));
                        pcUC.labelType.Text = "Охлаждение процессора";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(1)}" + Environment.NewLine + $"Рассеиваемая мощность(TDP): {reader.GetString(2)}";

                        flowLayoutPanel.Controls.Add(pcUC);

                        Type.Items.Add(reader.GetString(1));
                        TDP.Items.Add(reader.GetString(2));

                        RemoveDuplicates(Type);
                        RemoveDuplicates(TDP);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectRAM(FlowLayoutPanel companent, Guna2ComboBox DDR, Guna2ComboBox GB, Guna2ComboBox MGHz, Guna2ComboBox Times)
        {
            DDR.Items.Clear();
            GB.Items.Clear();
            MGHz.Items.Clear();
            Times.Items.Clear();

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
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип памяти: {reader.GetString(1)}" + Environment.NewLine + $"Объём памяти: {reader.GetString(2)} Гб" + Environment.NewLine + $"Тактовая частота: {reader.GetString(3)} МГц" + Environment.NewLine + $"Тайминги: {reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        DDR.Items.Add(reader.GetString(1));
                        GB.Items.Add(reader.GetString(2));
                        MGHz.Items.Add(reader.GetString(3));
                        Times.Items.Add(reader.GetString(4));

                        RemoveDuplicates(DDR);
                        RemoveDuplicates(GB);
                        RemoveDuplicates(MGHz);
                        RemoveDuplicates(Times);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectRAMSeek(FlowLayoutPanel companent, Guna2ComboBox DDR, Guna2ComboBox GB, Guna2ComboBox MGHz, Guna2ComboBox Times)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM RAM where DDR like @SearthDDR and GB like @SearthGB and MGHz like @SearthMGHz and Times like @SearthCL";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthDDR", (string.Format("{0}%", DDR.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthGB", (string.Format("{0}%", GB.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthMGHz", (string.Format("{0}%", MGHz.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthCL", (string.Format("{0}%", Times.SelectedItem)));

                    DDR.Items.Clear();
                    GB.Items.Clear();
                    MGHz.Items.Clear();
                    Times.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип памяти: DDR{reader.GetString(1)}" + Environment.NewLine + $"Объём памяти: {reader.GetString(2)} Гб" + Environment.NewLine + $"Тактовая частота: {reader.GetString(3)} МГц" + Environment.NewLine + $"Тайминги: {reader.GetString(4)}";

                        companent.Controls.Add(pcUC);

                        DDR.Items.Add(reader.GetString(1));
                        GB.Items.Add(reader.GetString(2));
                        MGHz.Items.Add(reader.GetString(3));
                        Times.Items.Add(reader.GetString(4));

                        RemoveDuplicates(DDR);
                        RemoveDuplicates(GB);
                        RemoveDuplicates(MGHz);
                        RemoveDuplicates(Times);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectPower(FlowLayoutPanel companent, Guna2ComboBox W, Guna2ComboBox FF)
        {
            W.Items.Clear();
            FF.Items.Clear();

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

                        companent.Controls.Add(pcUC);

                        W.Items.Add(reader.GetString(1));
                        FF.Items.Add(reader.GetString(2));

                        RemoveDuplicates(W);
                        RemoveDuplicates(FF);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectPowerSeek(FlowLayoutPanel companent, Guna2ComboBox W, Guna2ComboBox FF)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Power where Power(W) like @SearthW and FormFactor like @SearthFF";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthW", (string.Format("{0}%", W.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthFF", (string.Format("{0}%", FF.SelectedItem)));

                    W.Items.Clear();
                    FF.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Мощность: {reader.GetString(1)} W" + Environment.NewLine + $"Форм фактор: {reader.GetString(2)}";

                        companent.Controls.Add(pcUC);

                        W.Items.Add(reader.GetString(1));
                        FF.Items.Add(reader.GetString(2));

                        RemoveDuplicates(W);
                        RemoveDuplicates(FF);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectHDD(FlowLayoutPanel companent, Guna2ComboBox speed, Guna2ComboBox type)
        {
            speed.Items.Clear();
            type.Items.Clear();

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

                        companent.Controls.Add(pcUC);

                        speed.Items.Add(reader.GetString(1));
                        type.Items.Add(reader.GetString(2));

                        RemoveDuplicates(speed);
                        RemoveDuplicates(type);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SelectStorageSeek(FlowLayoutPanel companent, Guna2ComboBox speed, Guna2ComboBox type)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Storage where Speed like @SearthSpeed and Type like @SearthType";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthSpeed", (string.Format("{0}%", speed.SelectedItem)));
                    command.Parameters.AddWithValue("@SearthType", (string.Format("{0}%", type.SelectedItem)));

                    speed.Items.Clear();
                    type.Items.Clear();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PCCompUC pcUC = new PCCompUC();

                        pcUC.labelName.Text = reader.GetString(0);
                        pcUC.ID.Text = Convert.ToString(reader.GetInt32(5));
                        pcUC.labelType.Text = "Оперативная память";
                        pcUC.TextBoxHar.Text = $"Тип: {reader.GetString(2)}" + Environment.NewLine + $"Скорость записи: {reader.GetString(1)} мб/сек";

                        companent.Controls.Add(pcUC);

                        speed.Items.Add(reader.GetString(1));
                        type.Items.Add(reader.GetString(2));

                        RemoveDuplicates(speed);
                        RemoveDuplicates(type);
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

        public void AddResultStud(string selectedFilePath, string FIO_stud, string group, DateTime dateTime)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                SqlCommand command = new SqlCommand($"Insert INTO Prepod (_Group, FIO_stud, Result_comp, Data_Result) values (@Group, @FIO_stud, @Result_comp, @Data_Result)", con);
                command.Parameters.Add("@Result_comp", SqlDbType.VarBinary).Value = System.IO.File.ReadAllBytes(selectedFilePath);
                command.Parameters.AddWithValue("@FIO_stud", FIO_stud);
                command.Parameters.AddWithValue("@Group", group);
                command.Parameters.AddWithValue("Data_Result", dateTime);
                command.ExecuteNonQuery();
                con.Close();

                Methods.ResetLayout4();
            }
        }

        public void AddFile(string selectedFilePath, Guna2TextBox tb1)
        {

            using (SqlConnection con = new SqlConnection(conn))
            {
              
                con.Open();
                SqlCommand command = new SqlCommand($"Insert INTO txtResurs (Teoria, Name) values (@Teoria,@Name)", con);
                command.Parameters.Add("@Teoria", SqlDbType.VarBinary).Value = System.IO.File.ReadAllBytes(selectedFilePath);
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

        public void AddQuestion(string Question)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {

                con.Open();

                SqlCommand command = new SqlCommand($"Insert INTO Question (Questions) values (@Question)", con);
                command.Parameters.AddWithValue("@Question", Question);
                
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Данные успешно добавлены в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string SelectQuestion(int ID)
        {
            string result = "";

            try
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                string query = "SELECT * FROM Question where ID like @SearthID";

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearthID", (string.Format("{0}%", ID)));

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader.GetString(1);
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }
    }
}
