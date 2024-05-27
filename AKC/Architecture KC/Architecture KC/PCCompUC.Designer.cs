namespace Architecture_KC
{
    partial class PCCompUC
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SelectedTable = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.Label();
            this.SelectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.haracter = new System.Windows.Forms.TextBox();
            this.NameComp = new System.Windows.Forms.Label();
            this._Type = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.DelBtn);
            this.guna2Panel1.Controls.Add(this.SelectedTable);
            this.guna2Panel1.Controls.Add(this.IDBox);
            this.guna2Panel1.Controls.Add(this.SelectBtn);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.NameComp);
            this.guna2Panel1.Controls.Add(this._Type);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(455, 270);
            this.guna2Panel1.TabIndex = 0;
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.BackColor = System.Drawing.Color.Transparent;
            this.DelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.DelBtn.BorderRadius = 10;
            this.DelBtn.BorderThickness = 1;
            this.DelBtn.DefaultAutoSize = true;
            this.DelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DelBtn.FillColor = System.Drawing.Color.Transparent;
            this.DelBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DelBtn.ForeColor = System.Drawing.Color.LightGray;
            this.DelBtn.Location = new System.Drawing.Point(354, 229);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(90, 29);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SelectedTable
            // 
            this.SelectedTable.AutoSize = true;
            this.SelectedTable.ForeColor = System.Drawing.Color.LightGray;
            this.SelectedTable.Location = new System.Drawing.Point(11, 245);
            this.SelectedTable.Name = "SelectedTable";
            this.SelectedTable.Size = new System.Drawing.Size(76, 13);
            this.SelectedTable.TabIndex = 10;
            this.SelectedTable.Text = "SelectedTable";
            this.SelectedTable.Visible = false;
            // 
            // IDBox
            // 
            this.IDBox.AutoSize = true;
            this.IDBox.ForeColor = System.Drawing.Color.LightGray;
            this.IDBox.Location = new System.Drawing.Point(11, 229);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(18, 13);
            this.IDBox.TabIndex = 9;
            this.IDBox.Text = "ID";
            this.IDBox.Visible = false;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.SelectBtn.BorderRadius = 10;
            this.SelectBtn.BorderThickness = 1;
            this.SelectBtn.DefaultAutoSize = true;
            this.SelectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectBtn.FillColor = System.Drawing.Color.Transparent;
            this.SelectBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SelectBtn.ForeColor = System.Drawing.Color.LightGray;
            this.SelectBtn.Location = new System.Drawing.Point(183, 229);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(92, 29);
            this.SelectBtn.TabIndex = 8;
            this.SelectBtn.Text = "Выбрать";
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            this.SelectBtn.MouseEnter += new System.EventHandler(this.SelectBtn_MouseEnter);
            this.SelectBtn.MouseLeave += new System.EventHandler(this.SelectBtn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.haracter);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // haracter
            // 
            this.haracter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.haracter.BackColor = System.Drawing.Color.Gainsboro;
            this.haracter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.haracter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.haracter.ForeColor = System.Drawing.Color.Black;
            this.haracter.Location = new System.Drawing.Point(1, 18);
            this.haracter.Multiline = true;
            this.haracter.Name = "haracter";
            this.haracter.ReadOnly = true;
            this.haracter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.haracter.Size = new System.Drawing.Size(436, 131);
            this.haracter.TabIndex = 0;
            // 
            // NameComp
            // 
            this.NameComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameComp.AutoSize = true;
            this.NameComp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.NameComp.Location = new System.Drawing.Point(9, 37);
            this.NameComp.Name = "NameComp";
            this.NameComp.Size = new System.Drawing.Size(53, 21);
            this.NameComp.TabIndex = 5;
            this.NameComp.Text = "Name";
            // 
            // _Type
            // 
            this._Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this._Type.Location = new System.Drawing.Point(192, 0);
            this._Type.Name = "_Type";
            this._Type.Size = new System.Drawing.Size(263, 30);
            this._Type.TabIndex = 7;
            this._Type.Text = "Type";
            this._Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PCCompUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PCCompUC";
            this.Size = new System.Drawing.Size(458, 272);
            this.Load += new System.EventHandler(this.PCCompUC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox haracter;
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.Label _Type;
        private Guna.UI2.WinForms.Guna2Button SelectBtn;
        private System.Windows.Forms.Label IDBox;
        private System.Windows.Forms.Label SelectedTable;
        private Guna.UI2.WinForms.Guna2Button DelBtn;
    }
}
