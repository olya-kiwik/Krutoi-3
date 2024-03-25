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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NameComp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Type = new System.Windows.Forms.Label();
            this.haracter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 1;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(144, 144);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.guna2PictureBox1.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            this.guna2PictureBox1.MouseHover += new System.EventHandler(this.NameComp_MouseHover);
            // 
            // NameComp
            // 
            this.NameComp.AutoSize = true;
            this.NameComp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.NameComp.Location = new System.Drawing.Point(153, 1);
            this.NameComp.Name = "NameComp";
            this.NameComp.Size = new System.Drawing.Size(53, 21);
            this.NameComp.TabIndex = 2;
            this.NameComp.Text = "Name";
            this.NameComp.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.NameComp.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            this.NameComp.MouseHover += new System.EventHandler(this.NameComp_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haracter);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(157, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // _Type
            // 
            this._Type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this._Type.Location = new System.Drawing.Point(464, 1);
            this._Type.Name = "_Type";
            this._Type.Size = new System.Drawing.Size(244, 21);
            this._Type.TabIndex = 4;
            this._Type.Text = "Type";
            this._Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Type.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this._Type.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            // 
            // haracter
            // 
            this.haracter.BackColor = System.Drawing.Color.Gainsboro;
            this.haracter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.haracter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.haracter.ForeColor = System.Drawing.Color.Black;
            this.haracter.Location = new System.Drawing.Point(6, 21);
            this.haracter.Multiline = true;
            this.haracter.Name = "haracter";
            this.haracter.ReadOnly = true;
            this.haracter.Size = new System.Drawing.Size(539, 93);
            this.haracter.TabIndex = 0;
            this.haracter.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.haracter.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            // 
            // PCCompUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._Type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.NameComp);
            this.Name = "PCCompUC";
            this.Size = new System.Drawing.Size(715, 148);
            this.Load += new System.EventHandler(this.PCCompUC_Load);
            this.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NameComp_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _Type;
        private System.Windows.Forms.TextBox haracter;
    }
}
