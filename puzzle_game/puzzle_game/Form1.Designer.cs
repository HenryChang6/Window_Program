namespace puzzle_game
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_steps = new System.Windows.Forms.Label();
            this.btn_choose_photo = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.trackbar_diaplay = new System.Windows.Forms.TrackBar();
            this.lbl_hide = new System.Windows.Forms.Label();
            this.lbl_show = new System.Windows.Forms.Label();
            this.btn_init = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_diaplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(604, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_steps
            // 
            this.lbl_steps.AutoSize = true;
            this.lbl_steps.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_steps.Location = new System.Drawing.Point(447, 177);
            this.lbl_steps.Name = "lbl_steps";
            this.lbl_steps.Size = new System.Drawing.Size(99, 19);
            this.lbl_steps.TabIndex = 1;
            this.lbl_steps.Text = "移動步數:0";
            // 
            // btn_choose_photo
            // 
            this.btn_choose_photo.Font = new System.Drawing.Font("新細明體", 14F);
            this.btn_choose_photo.Location = new System.Drawing.Point(643, 401);
            this.btn_choose_photo.Name = "btn_choose_photo";
            this.btn_choose_photo.Size = new System.Drawing.Size(204, 33);
            this.btn_choose_photo.TabIndex = 2;
            this.btn_choose_photo.Text = "選擇圖片";
            this.btn_choose_photo.UseVisualStyleBackColor = true;
            this.btn_choose_photo.Click += new System.EventHandler(this.btn_choose_photo_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_time.Location = new System.Drawing.Point(447, 126);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(98, 19);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "時間: 00:00";
            // 
            // trackbar_diaplay
            // 
            this.trackbar_diaplay.Location = new System.Drawing.Point(660, 355);
            this.trackbar_diaplay.Maximum = 1;
            this.trackbar_diaplay.Name = "trackbar_diaplay";
            this.trackbar_diaplay.Size = new System.Drawing.Size(159, 45);
            this.trackbar_diaplay.TabIndex = 1;
            this.trackbar_diaplay.ValueChanged += new System.EventHandler(this.trackbar_diaplay_ValueChanged);
            // 
            // lbl_hide
            // 
            this.lbl_hide.AutoSize = true;
            this.lbl_hide.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_hide.Location = new System.Drawing.Point(588, 355);
            this.lbl_hide.Name = "lbl_hide";
            this.lbl_hide.Size = new System.Drawing.Size(66, 19);
            this.lbl_hide.TabIndex = 5;
            this.lbl_hide.Text = "不顯示";
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_show.Location = new System.Drawing.Point(825, 355);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(47, 19);
            this.lbl_show.TabIndex = 6;
            this.lbl_show.Text = "顯示";
            // 
            // btn_init
            // 
            this.btn_init.Font = new System.Drawing.Font("新細明體", 14F);
            this.btn_init.Location = new System.Drawing.Point(122, 401);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(204, 33);
            this.btn_init.TabIndex = 7;
            this.btn_init.Text = "繪製拼圖板";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 471);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.lbl_hide);
            this.Controls.Add(this.trackbar_diaplay);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_choose_photo);
            this.Controls.Add(this.lbl_steps);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_diaplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_steps;
        private System.Windows.Forms.Button btn_choose_photo;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TrackBar trackbar_diaplay;
        private System.Windows.Forms.Label lbl_hide;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Timer timer1;
    }
}

