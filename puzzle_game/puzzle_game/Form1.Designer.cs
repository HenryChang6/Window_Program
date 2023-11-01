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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_diaplay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pb8);
            this.panel1.Controls.Add(this.pb7);
            this.panel1.Controls.Add(this.pb6);
            this.panel1.Controls.Add(this.pb5);
            this.panel1.Controls.Add(this.pb4);
            this.panel1.Controls.Add(this.pb3);
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.pb0);
            this.panel1.Location = new System.Drawing.Point(76, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 8;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(210, 210);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(90, 90);
            this.pb8.TabIndex = 8;
            this.pb8.TabStop = false;
            this.pb8.Tag = "8";
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(105, 210);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(90, 90);
            this.pb7.TabIndex = 7;
            this.pb7.TabStop = false;
            this.pb7.Tag = "7";
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(0, 210);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(90, 90);
            this.pb6.TabIndex = 6;
            this.pb6.TabStop = false;
            this.pb6.Tag = "6";
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(210, 105);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(90, 90);
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            this.pb5.Tag = "5";
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(105, 105);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(90, 90);
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            this.pb4.Tag = "4";
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(0, 105);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(90, 90);
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            this.pb3.Tag = "3";
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(210, 0);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(90, 90);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Tag = "2";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(105, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(90, 90);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            // 
            // pb0
            // 
            this.pb0.Location = new System.Drawing.Point(0, 0);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(90, 90);
            this.pb0.TabIndex = 0;
            this.pb0.TabStop = false;
            this.pb0.Tag = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 471);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb0;
    }
}

