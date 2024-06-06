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
            this.link = new System.Windows.Forms.Label();
            this.delBt = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2Panel1.Size = new System.Drawing.Size(92, 89);
            this.guna2Panel1.TabIndex = 1;
            // 
            // imageVideo
            // 
            this.imageVideo.BorderRadius = 5;
            this.imageVideo.Image = global::Architecture_KC.Properties.Resources.play_button1;
            this.imageVideo.ImageRotate = 0F;
            this.imageVideo.Location = new System.Drawing.Point(3, 1);
            this.imageVideo.Name = "imageVideo";
            this.imageVideo.Size = new System.Drawing.Size(86, 85);
            this.imageVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVideo.TabIndex = 0;
            this.imageVideo.TabStop = false;
            this.imageVideo.Click += new System.EventHandler(this.imageVideo_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(114, 4);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(713, 45);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(290, 36);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "id";
            this.labelid.Visible = false;
            // 
            // PalyBt
            // 
            this.PalyBt.BackColor = System.Drawing.Color.Transparent;
            this.PalyBt.BorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.BorderRadius = 5;
            this.PalyBt.BorderThickness = 1;
            this.PalyBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PalyBt.DefaultAutoSize = true;
            this.PalyBt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PalyBt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PalyBt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PalyBt.FillColor = System.Drawing.Color.Transparent;
            this.PalyBt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.PalyBt.ForeColor = System.Drawing.Color.White;
            this.PalyBt.Location = new System.Drawing.Point(114, 59);
            this.PalyBt.Name = "PalyBt";
            this.PalyBt.Size = new System.Drawing.Size(112, 33);
            this.PalyBt.TabIndex = 4;
            this.PalyBt.Text = "Смотреть";
            this.PalyBt.Click += new System.EventHandler(this.PlayBt_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(226, 36);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(45, 13);
            this.link.TabIndex = 7;
            this.link.Text = "ссылка";
            this.link.Visible = false;
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
            this.delBt.Location = new System.Drawing.Point(708, 59);
            this.delBt.Name = "delBt";
            this.delBt.Size = new System.Drawing.Size(119, 33);
            this.delBt.TabIndex = 5;
            this.delBt.Text = " Удалить";
            this.delBt.Visible = false;
            this.delBt.Click += new System.EventHandler(this.delBt_Click);
            // 
            // VideoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.link);
            this.Controls.Add(this.delBt);
            this.Controls.Add(this.PalyBt);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "VideoUC";
            this.Size = new System.Drawing.Size(831, 98);
            this.Load += new System.EventHandler(this.VideoUC_Load);
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
        private System.Windows.Forms.Label link;
    }
}
