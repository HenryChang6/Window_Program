namespace practice_4_2
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_knife = new System.Windows.Forms.RadioButton();
            this.rdb_fertalizer = new System.Windows.Forms.RadioButton();
            this.rdb_seed = new System.Windows.Forms.RadioButton();
            this.rdb_water = new System.Windows.Forms.RadioButton();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.btn2_buyNsold = new System.Windows.Forms.Button();
            this.lbl2_fruit_amount = new System.Windows.Forms.Label();
            this.lbl2_fertalizer_amount = new System.Windows.Forms.Label();
            this.lbl2_seed_amount = new System.Windows.Forms.Label();
            this.cb2_fruit = new System.Windows.Forms.CheckBox();
            this.cb2_fertalizer = new System.Windows.Forms.CheckBox();
            this.cb2_seed = new System.Windows.Forms.CheckBox();
            this.lbl2_moneyleft = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.Page1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Page1);
            this.TabControl1.Controls.Add(this.Page2);
            this.TabControl1.Font = new System.Drawing.Font("新細明體", 16F);
            this.TabControl1.Location = new System.Drawing.Point(10, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1616, 921);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.Tag = "";
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.groupBox1);
            this.Page1.Font = new System.Drawing.Font("新細明體", 20F);
            this.Page1.Location = new System.Drawing.Point(8, 58);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(1600, 855);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "農場";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_knife);
            this.groupBox1.Controls.Add(this.rdb_fertalizer);
            this.groupBox1.Controls.Add(this.rdb_seed);
            this.groupBox1.Controls.Add(this.rdb_water);
            this.groupBox1.Location = new System.Drawing.Point(818, 715);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工具";
            // 
            // rdb_knife
            // 
            this.rdb_knife.AutoSize = true;
            this.rdb_knife.Font = new System.Drawing.Font("新細明體", 16F);
            this.rdb_knife.Location = new System.Drawing.Point(609, 70);
            this.rdb_knife.Name = "rdb_knife";
            this.rdb_knife.Size = new System.Drawing.Size(136, 47);
            this.rdb_knife.TabIndex = 3;
            this.rdb_knife.TabStop = true;
            this.rdb_knife.Text = "鐮刀";
            this.rdb_knife.UseVisualStyleBackColor = true;
            // 
            // rdb_fertalizer
            // 
            this.rdb_fertalizer.AutoSize = true;
            this.rdb_fertalizer.Font = new System.Drawing.Font("新細明體", 16F);
            this.rdb_fertalizer.Location = new System.Drawing.Point(434, 70);
            this.rdb_fertalizer.Name = "rdb_fertalizer";
            this.rdb_fertalizer.Size = new System.Drawing.Size(136, 47);
            this.rdb_fertalizer.TabIndex = 2;
            this.rdb_fertalizer.TabStop = true;
            this.rdb_fertalizer.Text = "肥料";
            this.rdb_fertalizer.UseVisualStyleBackColor = true;
            // 
            // rdb_seed
            // 
            this.rdb_seed.AutoSize = true;
            this.rdb_seed.Font = new System.Drawing.Font("新細明體", 16F);
            this.rdb_seed.Location = new System.Drawing.Point(255, 70);
            this.rdb_seed.Name = "rdb_seed";
            this.rdb_seed.Size = new System.Drawing.Size(136, 47);
            this.rdb_seed.TabIndex = 1;
            this.rdb_seed.TabStop = true;
            this.rdb_seed.Text = "種子";
            this.rdb_seed.UseVisualStyleBackColor = true;
            // 
            // rdb_water
            // 
            this.rdb_water.AutoSize = true;
            this.rdb_water.Font = new System.Drawing.Font("新細明體", 16F);
            this.rdb_water.Location = new System.Drawing.Point(28, 70);
            this.rdb_water.Name = "rdb_water";
            this.rdb_water.Size = new System.Drawing.Size(179, 47);
            this.rdb_water.TabIndex = 0;
            this.rdb_water.TabStop = true;
            this.rdb_water.Text = "澆水壺";
            this.rdb_water.UseVisualStyleBackColor = true;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.btn2_buyNsold);
            this.Page2.Controls.Add(this.lbl2_fruit_amount);
            this.Page2.Controls.Add(this.lbl2_fertalizer_amount);
            this.Page2.Controls.Add(this.lbl2_seed_amount);
            this.Page2.Controls.Add(this.cb2_fruit);
            this.Page2.Controls.Add(this.cb2_fertalizer);
            this.Page2.Controls.Add(this.cb2_seed);
            this.Page2.Controls.Add(this.lbl2_moneyleft);
            this.Page2.Font = new System.Drawing.Font("新細明體", 20F);
            this.Page2.Location = new System.Drawing.Point(8, 58);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(1600, 855);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "商店";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // btn2_buyNsold
            // 
            this.btn2_buyNsold.Location = new System.Drawing.Point(711, 617);
            this.btn2_buyNsold.Name = "btn2_buyNsold";
            this.btn2_buyNsold.Size = new System.Drawing.Size(178, 73);
            this.btn2_buyNsold.TabIndex = 7;
            this.btn2_buyNsold.Text = "買/賣";
            this.btn2_buyNsold.UseVisualStyleBackColor = true;
            this.btn2_buyNsold.Click += new System.EventHandler(this.btn2_buyNsold_Click);
            // 
            // lbl2_fruit_amount
            // 
            this.lbl2_fruit_amount.AutoSize = true;
            this.lbl2_fruit_amount.Location = new System.Drawing.Point(1165, 356);
            this.lbl2_fruit_amount.Name = "lbl2_fruit_amount";
            this.lbl2_fruit_amount.Size = new System.Drawing.Size(170, 54);
            this.lbl2_fruit_amount.TabIndex = 6;
            this.lbl2_fruit_amount.Text = "擁有:0";
            // 
            // lbl2_fertalizer_amount
            // 
            this.lbl2_fertalizer_amount.AutoSize = true;
            this.lbl2_fertalizer_amount.Location = new System.Drawing.Point(733, 356);
            this.lbl2_fertalizer_amount.Name = "lbl2_fertalizer_amount";
            this.lbl2_fertalizer_amount.Size = new System.Drawing.Size(170, 54);
            this.lbl2_fertalizer_amount.TabIndex = 5;
            this.lbl2_fertalizer_amount.Text = "擁有:5";
            // 
            // lbl2_seed_amount
            // 
            this.lbl2_seed_amount.AutoSize = true;
            this.lbl2_seed_amount.Location = new System.Drawing.Point(290, 356);
            this.lbl2_seed_amount.Name = "lbl2_seed_amount";
            this.lbl2_seed_amount.Size = new System.Drawing.Size(170, 54);
            this.lbl2_seed_amount.TabIndex = 4;
            this.lbl2_seed_amount.Text = "擁有:5";
            // 
            // cb2_fruit
            // 
            this.cb2_fruit.AutoSize = true;
            this.cb2_fruit.Location = new System.Drawing.Point(1173, 269);
            this.cb2_fruit.Name = "cb2_fruit";
            this.cb2_fruit.Size = new System.Drawing.Size(163, 58);
            this.cb2_fruit.TabIndex = 3;
            this.cb2_fruit.Text = "果實";
            this.cb2_fruit.UseVisualStyleBackColor = true;
            // 
            // cb2_fertalizer
            // 
            this.cb2_fertalizer.AutoSize = true;
            this.cb2_fertalizer.Location = new System.Drawing.Point(741, 269);
            this.cb2_fertalizer.Name = "cb2_fertalizer";
            this.cb2_fertalizer.Size = new System.Drawing.Size(163, 58);
            this.cb2_fertalizer.TabIndex = 2;
            this.cb2_fertalizer.Text = "肥料";
            this.cb2_fertalizer.UseVisualStyleBackColor = true;
            // 
            // cb2_seed
            // 
            this.cb2_seed.AutoSize = true;
            this.cb2_seed.Location = new System.Drawing.Point(298, 269);
            this.cb2_seed.Name = "cb2_seed";
            this.cb2_seed.Size = new System.Drawing.Size(163, 58);
            this.cb2_seed.TabIndex = 1;
            this.cb2_seed.Text = "種子";
            this.cb2_seed.UseVisualStyleBackColor = true;
            // 
            // lbl2_moneyleft
            // 
            this.lbl2_moneyleft.AutoSize = true;
            this.lbl2_moneyleft.Location = new System.Drawing.Point(713, 90);
            this.lbl2_moneyleft.Name = "lbl2_moneyleft";
            this.lbl2_moneyleft.Size = new System.Drawing.Size(220, 54);
            this.lbl2_moneyleft.TabIndex = 0;
            this.lbl2_moneyleft.Text = "金錢:100";
            this.lbl2_moneyleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 945);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Label lbl2_moneyleft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_knife;
        private System.Windows.Forms.RadioButton rdb_fertalizer;
        private System.Windows.Forms.RadioButton rdb_seed;
        private System.Windows.Forms.RadioButton rdb_water;
        private System.Windows.Forms.CheckBox cb2_fruit;
        private System.Windows.Forms.CheckBox cb2_fertalizer;
        private System.Windows.Forms.CheckBox cb2_seed;
        private System.Windows.Forms.Button btn2_buyNsold;
        private System.Windows.Forms.Label lbl2_fruit_amount;
        private System.Windows.Forms.Label lbl2_fertalizer_amount;
        private System.Windows.Forms.Label lbl2_seed_amount;
    }
}

