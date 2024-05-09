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
            this.NameComp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.haracter = new System.Windows.Forms.TextBox();
            this._Type = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameComp
            // 
            this.NameComp.AutoSize = true;
            this.NameComp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.NameComp.Location = new System.Drawing.Point(5, 1);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 288);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
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
            this.haracter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.haracter.Size = new System.Drawing.Size(234, 261);
            this.haracter.TabIndex = 0;
            this.haracter.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.haracter.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            // 
            // _Type
            // 
            this._Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Type.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this._Type.Location = new System.Drawing.Point(-1, 1);
            this._Type.Name = "_Type";
            this._Type.Size = new System.Drawing.Size(235, 21);
            this._Type.TabIndex = 4;
            this._Type.Text = "Type";
            this._Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Type.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this._Type.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            // 
            // PCCompUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._Type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameComp);
            this.Name = "PCCompUC";
            this.Size = new System.Drawing.Size(252, 316);
            this.Load += new System.EventHandler(this.PCCompUC_Load);
            this.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NameComp_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _Type;
        private System.Windows.Forms.TextBox haracter;
    }
}
