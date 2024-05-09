namespace Architecture_KC
{
    partial class FilterRAM
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.guna2ComboBox3.BorderRadius = 5;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Items.AddRange(new object[] {
            "ATX",
            "FlexATX",
            "SFX"});
            this.guna2ComboBox3.Location = new System.Drawing.Point(7, 266);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(238, 36);
            this.guna2ComboBox3.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "CAS Latence (CL)";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.guna2ComboBox2.BorderRadius = 5;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "ATX",
            "FlexATX",
            "SFX"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(7, 191);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(238, 36);
            this.guna2ComboBox2.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "Тактовая частота (МГц)";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "ATX",
            "FlexATX",
            "SFX"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(7, 123);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(238, 36);
            this.guna2ComboBox1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 46);
            this.label2.TabIndex = 57;
            this.label2.Text = "Объём одного модуля\r\nпамяти";
            // 
            // ff
            // 
            this.ff.BackColor = System.Drawing.Color.Transparent;
            this.ff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.ff.BorderRadius = 5;
            this.ff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ff.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.ff.ForeColor = System.Drawing.Color.Gainsboro;
            this.ff.ItemHeight = 30;
            this.ff.Items.AddRange(new object[] {
            "ATX",
            "FlexATX",
            "SFX"});
            this.ff.Location = new System.Drawing.Point(7, 28);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(238, 36);
            this.ff.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Тип памяти";
            // 
            // FilterRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2ComboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.label1);
            this.Name = "FilterRAM";
            this.Size = new System.Drawing.Size(248, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ff;
        private System.Windows.Forms.Label label1;
    }
}
