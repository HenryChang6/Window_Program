namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl2_name = new System.Windows.Forms.Label();
            this.lbl2_luck = new System.Windows.Forms.Label();
            this.lbl2_gender = new System.Windows.Forms.Label();
            this.lbl2_birth = new System.Windows.Forms.Label();
            this.lbl2_date = new System.Windows.Forms.Label();
            this.lbl2_animal = new System.Windows.Forms.Label();
            this.lbl2_suggestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2_title
            // 
            this.lbl2_title.AutoSize = true;
            this.lbl2_title.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_title.Location = new System.Drawing.Point(567, 33);
            this.lbl2_title.Name = "lbl2_title";
            this.lbl2_title.Size = new System.Drawing.Size(239, 54);
            this.lbl2_title.TabIndex = 0;
            this.lbl2_title.Text = "神諭時刻";
            this.lbl2_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_back.Location = new System.Drawing.Point(490, 740);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(391, 47);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "來，下面一位~";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl2_name
            // 
            this.lbl2_name.AutoSize = true;
            this.lbl2_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_name.Location = new System.Drawing.Point(359, 140);
            this.lbl2_name.Name = "lbl2_name";
            this.lbl2_name.Size = new System.Drawing.Size(78, 32);
            this.lbl2_name.TabIndex = 2;
            this.lbl2_name.Text = "姓名";
            // 
            // lbl2_luck
            // 
            this.lbl2_luck.AutoSize = true;
            this.lbl2_luck.Font = new System.Drawing.Font("新細明體", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_luck.Location = new System.Drawing.Point(173, 422);
            this.lbl2_luck.Name = "lbl2_luck";
            this.lbl2_luck.Size = new System.Drawing.Size(123, 43);
            this.lbl2_luck.TabIndex = 3;
            this.lbl2_luck.Text = "label2";
            // 
            // lbl2_gender
            // 
            this.lbl2_gender.AutoSize = true;
            this.lbl2_gender.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_gender.Location = new System.Drawing.Point(924, 140);
            this.lbl2_gender.Name = "lbl2_gender";
            this.lbl2_gender.Size = new System.Drawing.Size(78, 32);
            this.lbl2_gender.TabIndex = 5;
            this.lbl2_gender.Text = "性別";
            // 
            // lbl2_birth
            // 
            this.lbl2_birth.AutoSize = true;
            this.lbl2_birth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_birth.Location = new System.Drawing.Point(93, 251);
            this.lbl2_birth.Name = "lbl2_birth";
            this.lbl2_birth.Size = new System.Drawing.Size(174, 32);
            this.lbl2_birth.TabIndex = 6;
            this.lbl2_birth.Text = "出生年月日";
            // 
            // lbl2_date
            // 
            this.lbl2_date.AutoSize = true;
            this.lbl2_date.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_date.Location = new System.Drawing.Point(605, 251);
            this.lbl2_date.Name = "lbl2_date";
            this.lbl2_date.Size = new System.Drawing.Size(142, 32);
            this.lbl2_date.TabIndex = 7;
            this.lbl2_date.Text = "今日日期";
            // 
            // lbl2_animal
            // 
            this.lbl2_animal.AutoSize = true;
            this.lbl2_animal.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_animal.Location = new System.Drawing.Point(1111, 251);
            this.lbl2_animal.Name = "lbl2_animal";
            this.lbl2_animal.Size = new System.Drawing.Size(167, 32);
            this.lbl2_animal.TabIndex = 8;
            this.lbl2_animal.Text = "貓派or狗派";
            // 
            // lbl2_suggestion
            // 
            this.lbl2_suggestion.AutoSize = true;
            this.lbl2_suggestion.Font = new System.Drawing.Font("新細明體", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2_suggestion.Location = new System.Drawing.Point(173, 533);
            this.lbl2_suggestion.Name = "lbl2_suggestion";
            this.lbl2_suggestion.Size = new System.Drawing.Size(123, 43);
            this.lbl2_suggestion.TabIndex = 9;
            this.lbl2_suggestion.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 829);
            this.Controls.Add(this.lbl2_suggestion);
            this.Controls.Add(this.lbl2_animal);
            this.Controls.Add(this.lbl2_date);
            this.Controls.Add(this.lbl2_birth);
            this.Controls.Add(this.lbl2_gender);
            this.Controls.Add(this.lbl2_luck);
            this.Controls.Add(this.lbl2_name);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl2_title);
            this.Name = "Form2";
            this.Text = "AI算命系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2_title;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl2_name;
        private System.Windows.Forms.Label lbl2_luck;
        private System.Windows.Forms.Label lbl2_gender;
        private System.Windows.Forms.Label lbl2_birth;
        private System.Windows.Forms.Label lbl2_date;
        private System.Windows.Forms.Label lbl2_animal;
        private System.Windows.Forms.Label lbl2_suggestion;
    }
}