namespace Practice_6_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_record = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_choose_sound = new System.Windows.Forms.Button();
            this.lbl_sound_path = new System.Windows.Forms.Label();
            this.btn_set_alarm = new System.Windows.Forms.Button();
            this.lbl_AMorPM = new System.Windows.Forms.Label();
            this.lbl_set_alarm = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.lbl_dot1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 350);
            this.panel1.Controls.Add(this.lbl_record);
            this.panel1.Location = new System.Drawing.Point(982, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 265);
            this.panel1.TabIndex = 0;
            // 
            // lbl_record
            // 
            this.lbl_record.AutoSize = true;
            this.lbl_record.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_record.Location = new System.Drawing.Point(3, 9);
            this.lbl_record.Name = "lbl_record";
            this.lbl_record.Size = new System.Drawing.Size(35, 13);
            this.lbl_record.TabIndex = 0;
            this.lbl_record.Text = "label1";
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_export.Location = new System.Drawing.Point(982, 299);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(115, 25);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "匯出記錄檔";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_choose_sound
            // 
            this.btn_choose_sound.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_choose_sound.Location = new System.Drawing.Point(24, 254);
            this.btn_choose_sound.Name = "btn_choose_sound";
            this.btn_choose_sound.Size = new System.Drawing.Size(89, 25);
            this.btn_choose_sound.TabIndex = 2;
            this.btn_choose_sound.Text = "選擇鬧鈴";
            this.btn_choose_sound.UseVisualStyleBackColor = true;
            this.btn_choose_sound.Click += new System.EventHandler(this.btn_choose_sound_Click);
            // 
            // lbl_sound_path
            // 
            this.lbl_sound_path.AutoEllipsis = true;
            this.lbl_sound_path.AutoSize = true;
            this.lbl_sound_path.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_sound_path.Location = new System.Drawing.Point(119, 262);
            this.lbl_sound_path.Name = "lbl_sound_path";
            this.lbl_sound_path.Size = new System.Drawing.Size(77, 12);
            this.lbl_sound_path.TabIndex = 3;
            this.lbl_sound_path.Text = "尚未選擇檔案";
            // 
            // btn_set_alarm
            // 
            this.btn_set_alarm.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_set_alarm.Location = new System.Drawing.Point(854, 255);
            this.btn_set_alarm.Name = "btn_set_alarm";
            this.btn_set_alarm.Size = new System.Drawing.Size(66, 22);
            this.btn_set_alarm.TabIndex = 4;
            this.btn_set_alarm.Text = "啟動";
            this.btn_set_alarm.UseVisualStyleBackColor = true;
            this.btn_set_alarm.Click += new System.EventHandler(this.btn_set_alarm_Click);
            // 
            // lbl_AMorPM
            // 
            this.lbl_AMorPM.AutoSize = true;
            this.lbl_AMorPM.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_AMorPM.Location = new System.Drawing.Point(910, 182);
            this.lbl_AMorPM.Name = "lbl_AMorPM";
            this.lbl_AMorPM.Size = new System.Drawing.Size(66, 27);
            this.lbl_AMorPM.TabIndex = 5;
            this.lbl_AMorPM.Text = "上午";
            // 
            // lbl_set_alarm
            // 
            this.lbl_set_alarm.AutoSize = true;
            this.lbl_set_alarm.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_set_alarm.Location = new System.Drawing.Point(642, 260);
            this.lbl_set_alarm.Name = "lbl_set_alarm";
            this.lbl_set_alarm.Size = new System.Drawing.Size(77, 12);
            this.lbl_set_alarm.TabIndex = 6;
            this.lbl_set_alarm.Text = "設定鬧鐘時間";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(725, 255);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker.TabIndex = 7;
            // 
            // timer_update
            // 
            this.timer_update.Interval = 1000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // lbl_dot1
            // 
            this.lbl_dot1.AutoSize = true;
            this.lbl_dot1.Location = new System.Drawing.Point(352, 121);
            this.lbl_dot1.Name = "lbl_dot1";
            this.lbl_dot1.Size = new System.Drawing.Size(8, 12);
            this.lbl_dot1.TabIndex = 8;
            this.lbl_dot1.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(312, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(312, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(612, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(612, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 10);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 338);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_dot1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lbl_set_alarm);
            this.Controls.Add(this.lbl_AMorPM);
            this.Controls.Add(this.btn_set_alarm);
            this.Controls.Add(this.lbl_sound_path);
            this.Controls.Add(this.btn_choose_sound);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_choose_sound;
        private System.Windows.Forms.Label lbl_sound_path;
        private System.Windows.Forms.Label lbl_record;
        private System.Windows.Forms.Button btn_set_alarm;
        private System.Windows.Forms.Label lbl_AMorPM;
        private System.Windows.Forms.Label lbl_set_alarm;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Label lbl_dot1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

