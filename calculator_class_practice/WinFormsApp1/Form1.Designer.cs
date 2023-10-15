namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCapi = new TextBox();
            txtYear = new TextBox();
            txtRate = new TextBox();
            btnCal = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Principal: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 50);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Rate(%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 101);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Years:";
            // 
            // txtCapi
            // 
            txtCapi.Location = new Point(135, 47);
            txtCapi.Name = "txtCapi";
            txtCapi.Size = new Size(100, 23);
            txtCapi.TabIndex = 3;
            txtCapi.TextChanged += textBox1_TextChanged;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(135, 98);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 4;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(322, 47);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 5;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(322, 97);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(89, 24);
            btnCal.TabIndex = 6;
            btnCal.Text = "計算";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 172);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 172);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 247);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCal);
            Controls.Add(txtRate);
            Controls.Add(txtYear);
            Controls.Add(txtCapi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCapi;
        private TextBox txtYear;
        private TextBox txtRate;
        private Button btnCal;
        private Label label4;
        private Label label5;
    }
}