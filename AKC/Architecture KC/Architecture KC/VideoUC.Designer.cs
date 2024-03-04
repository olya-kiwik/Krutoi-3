namespace Architecture_KC
{
    partial class VideoUC
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
            this.imageVideo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.PalyBt = new Guna.UI2.WinForms.Guna2Button();
            this.EditBT = new Guna.UI2.WinForms.Guna2Button();
            this.delBt = new Guna.UI2.WinForms.Guna2Button();
            this.link = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.imageVideo);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(265, 174);
            this.guna2Panel1.TabIndex = 1;
            // 
            // imageVideo
            // 
            this.imageVideo.BorderRadius = 5;
            this.imageVideo.Image = global::Architecture_KC.Properties.Resources.play_button;
            this.imageVideo.ImageRotate = 0F;
            this.imageVideo.Location = new System.Drawing.Point(3, 1);
            this.imageVideo.Name = "imageVideo";
            this.imageVideo.Size = new System.Drawing.Size(259, 170);
            this.imageVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVideo.TabIndex = 0;
            this.imageVideo.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(274, 4);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 23);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(750, 14);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(35, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "label1";
            this.labelid.Visible = false;
            // 
            // PalyBt
            // 
            this.PalyBt.BorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.BorderRadius = 5;
            this.PalyBt.BorderThickness = 1;
            this.PalyBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PalyBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PalyBt.FillColor = System.Drawing.Color.Transparent;
            this.PalyBt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.PalyBt.ForeColor = System.Drawing.Color.Black;
            this.PalyBt.Location = new System.Drawing.Point(278, 123);
            this.PalyBt.Name = "PalyBt";
            this.PalyBt.Size = new System.Drawing.Size(180, 45);
            this.PalyBt.TabIndex = 4;
            this.PalyBt.Text = "Смотреть";
            this.PalyBt.Click += new System.EventHandler(this.PlayBt_Click);
            // 
            // EditBT
            // 
            this.EditBT.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBT.BorderRadius = 5;
            this.EditBT.BorderThickness = 1;
            this.EditBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBT.FillColor = System.Drawing.Color.Transparent;
            this.EditBT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditBT.ForeColor = System.Drawing.Color.Black;
            this.EditBT.Image = global::Architecture_KC.Properties.Resources.edit;
            this.EditBT.Location = new System.Drawing.Point(674, 72);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(111, 45);
            this.EditBT.TabIndex = 6;
            this.EditBT.Text = "Изменить";
            this.EditBT.Visible = false;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // delBt
            // 
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
            this.delBt.ForeColor = System.Drawing.Color.Black;
            this.delBt.Image = global::Architecture_KC.Properties.Resources.free_icon_bin_8556181;
            this.delBt.Location = new System.Drawing.Point(674, 123);
            this.delBt.Name = "delBt";
            this.delBt.Size = new System.Drawing.Size(111, 45);
            this.delBt.TabIndex = 5;
            this.delBt.Text = " Удалить";
            this.delBt.Visible = false;
            this.delBt.Click += new System.EventHandler(this.delBt_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(333, 61);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(35, 13);
            this.link.TabIndex = 7;
            this.link.Text = "label1";
            this.link.Visible = false;
            // 
            // VideoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.link);
            this.Controls.Add(this.EditBT);
            this.Controls.Add(this.delBt);
            this.Controls.Add(this.PalyBt);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "VideoUC";
            this.Size = new System.Drawing.Size(800, 180);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imageVideo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label labelid;
        private Guna.UI2.WinForms.Guna2Button PalyBt;
        private Guna.UI2.WinForms.Guna2Button delBt;
        private Guna.UI2.WinForms.Guna2Button EditBT;
        private System.Windows.Forms.Label link;
    }
}
