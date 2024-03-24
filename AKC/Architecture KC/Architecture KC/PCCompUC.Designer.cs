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
            this.LabalId = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NameComp = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabalId
            // 
            this.LabalId.AutoSize = true;
            this.LabalId.Location = new System.Drawing.Point(87, 70);
            this.LabalId.Name = "LabalId";
            this.LabalId.Size = new System.Drawing.Size(15, 13);
            this.LabalId.TabIndex = 0;
            this.LabalId.Text = "id";
            this.LabalId.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 1;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(224, 188);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // NameComp
            // 
            this.NameComp.AutoSize = true;
            this.NameComp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.NameComp.Location = new System.Drawing.Point(88, 196);
            this.NameComp.Name = "NameComp";
            this.NameComp.Size = new System.Drawing.Size(53, 21);
            this.NameComp.TabIndex = 2;
            this.NameComp.Text = "Name";
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.Location = new System.Drawing.Point(136, 83);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(35, 13);
            this.TableName.TabIndex = 3;
            this.TableName.Text = "label1";
            this.TableName.Visible = false;
            // 
            // PCCompUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.NameComp);
            this.Controls.Add(this.LabalId);
            this.Name = "PCCompUC";
            this.Size = new System.Drawing.Size(230, 230);
            this.Load += new System.EventHandler(this.PCCompUC_Load);
            this.MouseEnter += new System.EventHandler(this.PCCompUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PCCompUC_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabalId;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.Label TableName;
    }
}
