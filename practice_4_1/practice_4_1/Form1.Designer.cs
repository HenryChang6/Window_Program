namespace practice_4_1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(91, 112);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 134);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(246, 112);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 134);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(402, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 134);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(566, 112);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(108, 134);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn_unlock
            // 
            this.btn_unlock.Location = new System.Drawing.Point(318, 366);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(111, 29);
            this.btn_unlock.TabIndex = 4;
            this.btn_unlock.Text = "解鎖";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1.Location = new System.Drawing.Point(113, 88);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 21);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2.Location = new System.Drawing.Point(267, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 21);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "label1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl3.Location = new System.Drawing.Point(428, 88);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(58, 21);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "label1";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl4.Location = new System.Drawing.Point(591, 88);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(58, 21);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}

