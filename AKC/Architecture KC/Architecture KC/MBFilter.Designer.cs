namespace Architecture_KC
{
    partial class MBFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Chipset = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FF = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DDR = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Soket = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Creator = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Chipset);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FF);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ConfirmBtn);
            this.panel1.Controls.Add(this.DDR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Soket);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Creator);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 534);
            this.panel1.TabIndex = 45;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(10, 424);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(206, 45);
            this.guna2Button1.TabIndex = 47;
            this.guna2Button1.Text = "Сбросить";
            this.guna2Button1.Visible = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Chipset
            // 
            this.Chipset.BackColor = System.Drawing.Color.Transparent;
            this.Chipset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.Chipset.BorderRadius = 5;
            this.Chipset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Chipset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chipset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Chipset.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Chipset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Chipset.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Chipset.ForeColor = System.Drawing.Color.White;
            this.Chipset.ItemHeight = 30;
            this.Chipset.Items.AddRange(new object[] {
            "ATX",
            "SFX"});
            this.Chipset.Location = new System.Drawing.Point(10, 318);
            this.Chipset.Name = "Chipset";
            this.Chipset.Size = new System.Drawing.Size(206, 36);
            this.Chipset.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Чипсет";
            // 
            // FF
            // 
            this.FF.BackColor = System.Drawing.Color.Transparent;
            this.FF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.FF.BorderRadius = 5;
            this.FF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.FF.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FF.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.FF.ForeColor = System.Drawing.Color.White;
            this.FF.ItemHeight = 30;
            this.FF.Items.AddRange(new object[] {
            "ATX",
            "SFX"});
            this.FF.Location = new System.Drawing.Point(10, 250);
            this.FF.Name = "FF";
            this.FF.Size = new System.Drawing.Size(206, 36);
            this.FF.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Форм-фактор";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.ConfirmBtn.BorderRadius = 10;
            this.ConfirmBtn.BorderThickness = 1;
            this.ConfirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBtn.FillColor = System.Drawing.Color.Transparent;
            this.ConfirmBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(10, 475);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(206, 45);
            this.ConfirmBtn.TabIndex = 45;
            this.ConfirmBtn.Text = "Найти";
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // DDR
            // 
            this.DDR.BackColor = System.Drawing.Color.Transparent;
            this.DDR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.DDR.BorderRadius = 5;
            this.DDR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.DDR.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DDR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DDR.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.DDR.ForeColor = System.Drawing.Color.White;
            this.DDR.ItemHeight = 30;
            this.DDR.Items.AddRange(new object[] {
            "ATX",
            "SFX"});
            this.DDR.Location = new System.Drawing.Point(10, 183);
            this.DDR.Name = "DDR";
            this.DDR.Size = new System.Drawing.Size(206, 36);
            this.DDR.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 42);
            this.label2.TabIndex = 43;
            this.label2.Text = "Тип поддерживоемой\r\nпамяти (DDR)";
            // 
            // Soket
            // 
            this.Soket.BackColor = System.Drawing.Color.Transparent;
            this.Soket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.Soket.BorderRadius = 5;
            this.Soket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Soket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Soket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Soket.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Soket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Soket.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Soket.ForeColor = System.Drawing.Color.White;
            this.Soket.ItemHeight = 30;
            this.Soket.Items.AddRange(new object[] {
            "ATX",
            "SFX"});
            this.Soket.Location = new System.Drawing.Point(10, 95);
            this.Soket.Name = "Soket";
            this.Soket.Size = new System.Drawing.Size(206, 36);
            this.Soket.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Сокет";
            // 
            // Creator
            // 
            this.Creator.BackColor = System.Drawing.Color.Transparent;
            this.Creator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(222)))), ((int)(((byte)(85)))));
            this.Creator.BorderRadius = 5;
            this.Creator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Creator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Creator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Creator.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Creator.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Creator.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Creator.ForeColor = System.Drawing.Color.White;
            this.Creator.ItemHeight = 30;
            this.Creator.Items.AddRange(new object[] {
            "ATX",
            "SFX"});
            this.Creator.Location = new System.Drawing.Point(10, 27);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(206, 36);
            this.Creator.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Производитель";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(233, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 534);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // MBFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MBFilter";
            this.Text = "MBFilter";
            this.Load += new System.EventHandler(this.MBFilter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2ComboBox Chipset;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ComboBox FF;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button ConfirmBtn;
        public Guna.UI2.WinForms.Guna2ComboBox DDR;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox Soket;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox Creator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}