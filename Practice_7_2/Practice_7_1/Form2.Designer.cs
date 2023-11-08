namespace Practice_7_1
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
            this.lbl_vocab = new System.Windows.Forms.Label();
            this.lbl_chinese = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_isTag = new System.Windows.Forms.CheckBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_vocab
            // 
            this.lbl_vocab.AutoSize = true;
            this.lbl_vocab.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_vocab.Location = new System.Drawing.Point(47, 52);
            this.lbl_vocab.Name = "lbl_vocab";
            this.lbl_vocab.Size = new System.Drawing.Size(53, 19);
            this.lbl_vocab.TabIndex = 0;
            this.lbl_vocab.Text = "label1";
            // 
            // lbl_chinese
            // 
            this.lbl_chinese.AutoSize = true;
            this.lbl_chinese.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_chinese.Location = new System.Drawing.Point(47, 147);
            this.lbl_chinese.Name = "lbl_chinese";
            this.lbl_chinese.Size = new System.Drawing.Size(53, 19);
            this.lbl_chinese.TabIndex = 1;
            this.lbl_chinese.Text = "label2";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_category.Location = new System.Drawing.Point(47, 240);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(53, 19);
            this.lbl_category.TabIndex = 2;
            this.lbl_category.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.lbl_chinese);
            this.panel1.Controls.Add(this.lbl_vocab);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 451);
            this.panel1.TabIndex = 3;
            // 
            // cb_isTag
            // 
            this.cb_isTag.AutoSize = true;
            this.cb_isTag.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_isTag.Location = new System.Drawing.Point(664, 240);
            this.cb_isTag.Name = "cb_isTag";
            this.cb_isTag.Size = new System.Drawing.Size(66, 23);
            this.cb_isTag.TabIndex = 4;
            this.cb_isTag.Text = "標記";
            this.cb_isTag.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.Location = new System.Drawing.Point(664, 305);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(98, 38);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "查看";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_next.Location = new System.Drawing.Point(664, 378);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(98, 38);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "下一個";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.cb_isTag);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "單字測驗";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vocab;
        private System.Windows.Forms.Label lbl_chinese;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_isTag;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_next;
    }
}