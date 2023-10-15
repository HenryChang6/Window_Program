namespace WindowsFormsApp1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_animal = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.tb_birth = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_animal = new System.Windows.Forms.TextBox();
            this.lbl_error_gender = new System.Windows.Forms.Label();
            this.lbl_error_birth = new System.Windows.Forms.Label();
            this.lbl_error_animal = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_title.Location = new System.Drawing.Point(568, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(239, 54);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "資料輸入";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_name.Location = new System.Drawing.Point(235, 170);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 32);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "姓名";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_gender.Location = new System.Drawing.Point(235, 270);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(78, 32);
            this.lbl_gender.TabIndex = 2;
            this.lbl_gender.Text = "性別";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_birth.Location = new System.Drawing.Point(235, 370);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(174, 32);
            this.lbl_birth.TabIndex = 3;
            this.lbl_birth.Text = "出生年月日";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_date.Location = new System.Drawing.Point(235, 470);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(142, 32);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "今日日期";
            // 
            // lbl_animal
            // 
            this.lbl_animal.AutoSize = true;
            this.lbl_animal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_animal.Location = new System.Drawing.Point(235, 570);
            this.lbl_animal.Name = "lbl_animal";
            this.lbl_animal.Size = new System.Drawing.Size(183, 32);
            this.lbl_animal.TabIndex = 5;
            this.lbl_animal.Text = "貓派 or 狗派";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(481, 167);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(446, 46);
            this.tb_name.TabIndex = 6;
            // 
            // tb_gender
            // 
            this.tb_gender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_gender.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_gender.Location = new System.Drawing.Point(481, 267);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.Size = new System.Drawing.Size(446, 46);
            this.tb_gender.TabIndex = 7;
            this.tb_gender.Text = "男or女";
            this.tb_gender.Enter += new System.EventHandler(this.tb_gender_Enter);
            this.tb_gender.Leave += new System.EventHandler(this.tb_gender_Leave);
            // 
            // tb_birth
            // 
            this.tb_birth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_birth.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_birth.Location = new System.Drawing.Point(481, 367);
            this.tb_birth.Name = "tb_birth";
            this.tb_birth.Size = new System.Drawing.Size(446, 46);
            this.tb_birth.TabIndex = 8;
            this.tb_birth.Text = "格式為xxxx/xx/xx";
            this.tb_birth.Enter += new System.EventHandler(this.tb_birth_Enter);
            this.tb_birth.Leave += new System.EventHandler(this.tb_birth_Leave);
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_date.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_date.Location = new System.Drawing.Point(481, 467);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(446, 46);
            this.tb_date.TabIndex = 9;
            this.tb_date.Text = "格式為xxxx/xx/xx";
            this.tb_date.Enter += new System.EventHandler(this.tb_date_Enter);
            this.tb_date.Leave += new System.EventHandler(this.tb_date_Leave);
            // 
            // tb_animal
            // 
            this.tb_animal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_animal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_animal.Location = new System.Drawing.Point(481, 567);
            this.tb_animal.Name = "tb_animal";
            this.tb_animal.Size = new System.Drawing.Size(446, 46);
            this.tb_animal.TabIndex = 10;
            this.tb_animal.Text = "貓or狗";
            this.tb_animal.Enter += new System.EventHandler(this.tb_animal_Enter);
            this.tb_animal.Leave += new System.EventHandler(this.tb_animal_Leave);
            // 
            // lbl_error_gender
            // 
            this.lbl_error_gender.AutoSize = true;
            this.lbl_error_gender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_error_gender.Location = new System.Drawing.Point(985, 270);
            this.lbl_error_gender.Name = "lbl_error_gender";
            this.lbl_error_gender.Size = new System.Drawing.Size(86, 32);
            this.lbl_error_gender.TabIndex = 11;
            this.lbl_error_gender.Text = "label1";
            // 
            // lbl_error_birth
            // 
            this.lbl_error_birth.AutoSize = true;
            this.lbl_error_birth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_error_birth.Location = new System.Drawing.Point(985, 370);
            this.lbl_error_birth.Name = "lbl_error_birth";
            this.lbl_error_birth.Size = new System.Drawing.Size(86, 32);
            this.lbl_error_birth.TabIndex = 12;
            this.lbl_error_birth.Text = "label1";
            // 
            // lbl_error_animal
            // 
            this.lbl_error_animal.AutoSize = true;
            this.lbl_error_animal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_error_animal.Location = new System.Drawing.Point(985, 570);
            this.lbl_error_animal.Name = "lbl_error_animal";
            this.lbl_error_animal.Size = new System.Drawing.Size(86, 32);
            this.lbl_error_animal.TabIndex = 13;
            this.lbl_error_animal.Text = "label1";
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show.Location = new System.Drawing.Point(481, 707);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(445, 56);
            this.btn_show.TabIndex = 14;
            this.btn_show.Text = "AI大神請告訴我答案吧";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1374, 829);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lbl_error_animal);
            this.Controls.Add(this.lbl_error_birth);
            this.Controls.Add(this.lbl_error_gender);
            this.Controls.Add(this.tb_animal);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_birth);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_animal);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "AI算命系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_animal;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.TextBox tb_birth;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_animal;
        private System.Windows.Forms.Label lbl_error_gender;
        private System.Windows.Forms.Label lbl_error_birth;
        private System.Windows.Forms.Label lbl_error_animal;
        private System.Windows.Forms.Button btn_show;
    }
}

