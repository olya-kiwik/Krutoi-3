﻿namespace Architecture_KC
{
    partial class TestUC
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
            this.delBt = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // delBt
            // 
            this.delBt.BackColor = System.Drawing.Color.Transparent;
            this.delBt.BorderColor = System.Drawing.Color.DarkGray;
            this.delBt.BorderRadius = 5;
            this.delBt.BorderThickness = 1;
            this.delBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delBt.FillColor = System.Drawing.Color.Transparent;
            this.delBt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.delBt.ForeColor = System.Drawing.Color.White;
            this.delBt.Image = global::Architecture_KC.Properties.Resources.free_icon_bin_8556181;
            this.delBt.Location = new System.Drawing.Point(715, 77);
            this.delBt.Name = "delBt";
            this.delBt.Size = new System.Drawing.Size(110, 33);
            this.delBt.TabIndex = 9;
            this.delBt.Text = "Удалить";
            this.delBt.Visible = false;
            this.delBt.Click += new System.EventHandler(this.Del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(204, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(121, 77);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 33);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Пройти";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тема";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Architecture_KC.Properties.Resources.тест;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(108, 114);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(400, 61);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(23, 13);
            this.labelLink.TabIndex = 10;
            this.labelLink.Text = "link";
            this.labelLink.Visible = false;
            // 
            // TestUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.delBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "TestUC";
            this.Size = new System.Drawing.Size(829, 120);
            this.Load += new System.EventHandler(this.TestUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button delBt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label labelLink;
    }
}
