namespace Architecture_KC
{
    partial class CPU_FAN_Filter
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
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(7, 104);
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
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Рассеиваемая мощность (Вт)";
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
            this.ff.Location = new System.Drawing.Point(7, 29);
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
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Тип конструкции";
            // 
            // CPU_FAN_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.label1);
            this.Name = "CPU_FAN_Filter";
            this.Size = new System.Drawing.Size(248, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ff;
        private System.Windows.Forms.Label label1;
    }
}
