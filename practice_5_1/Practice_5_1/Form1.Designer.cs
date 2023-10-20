namespace Practice_5_1
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
            this.lbl_phase = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_phase
            // 
            this.lbl_phase.AutoSize = true;
            this.lbl_phase.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_phase.Location = new System.Drawing.Point(330, 54);
            this.lbl_phase.Name = "lbl_phase";
            this.lbl_phase.Size = new System.Drawing.Size(94, 21);
            this.lbl_phase.TabIndex = 0;
            this.lbl_phase.Text = "準備階段";
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_clock.Location = new System.Drawing.Point(368, 94);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(20, 21);
            this.lbl_clock.TabIndex = 1;
            this.lbl_clock.Text = "5";
            // 
            // btn_start
            // 
            this.btn_start.AccessibleDescription = "btn_start";
            this.btn_start.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(273, 267);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(211, 49);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "開始遊戲";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
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
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.lbl_phase);
            this.Name = "Form1";
            this.Text = "記憶小遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phase;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
    }
}

