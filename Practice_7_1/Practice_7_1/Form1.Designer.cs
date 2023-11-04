namespace Practice_7_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save_as_newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItemword = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_word = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_search_word = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_inspect = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_content = new System.Windows.Forms.Label();
            this.panel_chk = new System.Windows.Forms.Panel();
            this.panel_wb = new System.Windows.Forms.Panel();
            this.lbl_vocab = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_vocab = new System.Windows.Forms.TextBox();
            this.tb_chinese = new System.Windows.Forms.TextBox();
            this.lbl_chinese = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.chk_vocab = new System.Windows.Forms.CheckBox();
            this.chk_chinese = new System.Windows.Forms.CheckBox();
            this.chk_category = new System.Windows.Forms.CheckBox();
            this.btn_func_action = new System.Windows.Forms.Button();
            this.lbl_search_result = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lbl_init_state_info = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel_chk.SuspendLayout();
            this.panel_wb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.功能ToolStripMenuItemword,
            this.menu_inspect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_open,
            this.menu_save,
            this.menu_save_as_newFile,
            this.menu_exit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // menu_new
            // 
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(180, 22);
            this.menu_new.Text = "新增";
            this.menu_new.Click += new System.EventHandler(this.menu_new_Click);
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(180, 22);
            this.menu_open.Text = "開啟舊檔";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(180, 22);
            this.menu_save.Text = "儲存";
            this.menu_save.Click += new System.EventHandler(this.menu_save_Click);
            // 
            // menu_save_as_newFile
            // 
            this.menu_save_as_newFile.Name = "menu_save_as_newFile";
            this.menu_save_as_newFile.Size = new System.Drawing.Size(180, 22);
            this.menu_save_as_newFile.Text = "另存新檔";
            this.menu_save_as_newFile.Click += new System.EventHandler(this.menu_save_as_newFile_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(180, 22);
            this.menu_exit.Text = "離開";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // 功能ToolStripMenuItemword
            // 
            this.功能ToolStripMenuItemword.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add_word,
            this.menu_search_word});
            this.功能ToolStripMenuItemword.Name = "功能ToolStripMenuItemword";
            this.功能ToolStripMenuItemword.Size = new System.Drawing.Size(43, 20);
            this.功能ToolStripMenuItemword.Text = "功能";
            // 
            // menu_add_word
            // 
            this.menu_add_word.Name = "menu_add_word";
            this.menu_add_word.Size = new System.Drawing.Size(180, 22);
            this.menu_add_word.Text = "新增單字";
            this.menu_add_word.Click += new System.EventHandler(this.menu_add_word_Click);
            // 
            // menu_search_word
            // 
            this.menu_search_word.Name = "menu_search_word";
            this.menu_search_word.Size = new System.Drawing.Size(180, 22);
            this.menu_search_word.Text = "搜尋單字";
            this.menu_search_word.Click += new System.EventHandler(this.menu_search_word_Click);
            // 
            // menu_inspect
            // 
            this.menu_inspect.Name = "menu_inspect";
            this.menu_inspect.Size = new System.Drawing.Size(43, 20);
            this.menu_inspect.Text = "檢視";
            this.menu_inspect.Click += new System.EventHandler(this.menu_inspect_Click);
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_content.Location = new System.Drawing.Point(10, 31);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(53, 19);
            this.lbl_content.TabIndex = 1;
            this.lbl_content.Text = "label1";
            // 
            // panel_chk
            // 
            this.panel_chk.Controls.Add(this.chk_category);
            this.panel_chk.Controls.Add(this.chk_chinese);
            this.panel_chk.Controls.Add(this.chk_vocab);
            this.panel_chk.Location = new System.Drawing.Point(521, 31);
            this.panel_chk.Name = "panel_chk";
            this.panel_chk.Size = new System.Drawing.Size(51, 419);
            this.panel_chk.TabIndex = 2;
            // 
            // panel_wb
            // 
            this.panel_wb.Controls.Add(this.btn_func_action);
            this.panel_wb.Controls.Add(this.lbl_category);
            this.panel_wb.Controls.Add(this.tb_chinese);
            this.panel_wb.Controls.Add(this.lbl_chinese);
            this.panel_wb.Controls.Add(this.tb_vocab);
            this.panel_wb.Controls.Add(this.cb_category);
            this.panel_wb.Controls.Add(this.lbl_vocab);
            this.panel_wb.Location = new System.Drawing.Point(568, 31);
            this.panel_wb.Name = "panel_wb";
            this.panel_wb.Size = new System.Drawing.Size(193, 419);
            this.panel_wb.TabIndex = 3;
            // 
            // lbl_vocab
            // 
            this.lbl_vocab.AutoSize = true;
            this.lbl_vocab.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_vocab.Location = new System.Drawing.Point(10, 61);
            this.lbl_vocab.Name = "lbl_vocab";
            this.lbl_vocab.Size = new System.Drawing.Size(47, 19);
            this.lbl_vocab.TabIndex = 0;
            this.lbl_vocab.Text = "單字";
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "n",
            "v",
            "adj",
            "adv",
            "prep",
            "conj",
            "phr",
            "abbr",
            "pron",
            "other"});
            this.cb_category.Location = new System.Drawing.Point(14, 307);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(167, 27);
            this.cb_category.TabIndex = 1;
            // 
            // tb_vocab
            // 
            this.tb_vocab.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_vocab.Location = new System.Drawing.Point(14, 83);
            this.tb_vocab.Name = "tb_vocab";
            this.tb_vocab.Size = new System.Drawing.Size(167, 30);
            this.tb_vocab.TabIndex = 2;
            // 
            // tb_chinese
            // 
            this.tb_chinese.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_chinese.Location = new System.Drawing.Point(14, 188);
            this.tb_chinese.Name = "tb_chinese";
            this.tb_chinese.Size = new System.Drawing.Size(167, 30);
            this.tb_chinese.TabIndex = 4;
            // 
            // lbl_chinese
            // 
            this.lbl_chinese.AutoSize = true;
            this.lbl_chinese.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_chinese.Location = new System.Drawing.Point(10, 166);
            this.lbl_chinese.Name = "lbl_chinese";
            this.lbl_chinese.Size = new System.Drawing.Size(47, 19);
            this.lbl_chinese.TabIndex = 3;
            this.lbl_chinese.Text = "中文";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_category.Location = new System.Drawing.Point(10, 273);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(47, 19);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "詞性";
            // 
            // chk_vocab
            // 
            this.chk_vocab.AutoSize = true;
            this.chk_vocab.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_vocab.Location = new System.Drawing.Point(12, 89);
            this.chk_vocab.Name = "chk_vocab";
            this.chk_vocab.Size = new System.Drawing.Size(15, 14);
            this.chk_vocab.TabIndex = 0;
            this.chk_vocab.UseVisualStyleBackColor = true;
            // 
            // chk_chinese
            // 
            this.chk_chinese.AutoSize = true;
            this.chk_chinese.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_chinese.Location = new System.Drawing.Point(12, 194);
            this.chk_chinese.Name = "chk_chinese";
            this.chk_chinese.Size = new System.Drawing.Size(15, 14);
            this.chk_chinese.TabIndex = 1;
            this.chk_chinese.UseVisualStyleBackColor = true;
            // 
            // chk_category
            // 
            this.chk_category.AutoSize = true;
            this.chk_category.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk_category.Location = new System.Drawing.Point(12, 313);
            this.chk_category.Name = "chk_category";
            this.chk_category.Size = new System.Drawing.Size(15, 14);
            this.chk_category.TabIndex = 2;
            this.chk_category.UseVisualStyleBackColor = true;
            // 
            // btn_func_action
            // 
            this.btn_func_action.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_func_action.Location = new System.Drawing.Point(88, 380);
            this.btn_func_action.Name = "btn_func_action";
            this.btn_func_action.Size = new System.Drawing.Size(74, 27);
            this.btn_func_action.TabIndex = 6;
            this.btn_func_action.Text = "button1";
            this.btn_func_action.UseVisualStyleBackColor = true;
            this.btn_func_action.Click += new System.EventHandler(this.btn_func_action_Click);
            // 
            // lbl_search_result
            // 
            this.lbl_search_result.AutoSize = true;
            this.lbl_search_result.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_search_result.Location = new System.Drawing.Point(12, 31);
            this.lbl_search_result.Name = "lbl_search_result";
            this.lbl_search_result.Size = new System.Drawing.Size(53, 19);
            this.lbl_search_result.TabIndex = 4;
            this.lbl_search_result.Text = "label1";
            // 
            // lbl_init_state_info
            // 
            this.lbl_init_state_info.AutoSize = true;
            this.lbl_init_state_info.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_init_state_info.Location = new System.Drawing.Point(12, 31);
            this.lbl_init_state_info.Name = "lbl_init_state_info";
            this.lbl_init_state_info.Size = new System.Drawing.Size(53, 19);
            this.lbl_init_state_info.TabIndex = 5;
            this.lbl_init_state_info.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.lbl_init_state_info);
            this.Controls.Add(this.lbl_search_result);
            this.Controls.Add(this.panel_wb);
            this.Controls.Add(this.panel_chk);
            this.Controls.Add(this.lbl_content);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "單字卡";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_chk.ResumeLayout(false);
            this.panel_chk.PerformLayout();
            this.panel_wb.ResumeLayout(false);
            this.panel_wb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItemword;
        private System.Windows.Forms.ToolStripMenuItem menu_add_word;
        private System.Windows.Forms.ToolStripMenuItem menu_search_word;
        private System.Windows.Forms.ToolStripMenuItem menu_inspect;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_save_as_newFile;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Panel panel_chk;
        private System.Windows.Forms.Panel panel_wb;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox tb_chinese;
        private System.Windows.Forms.Label lbl_chinese;
        private System.Windows.Forms.TextBox tb_vocab;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label lbl_vocab;
        private System.Windows.Forms.CheckBox chk_category;
        private System.Windows.Forms.CheckBox chk_chinese;
        private System.Windows.Forms.CheckBox chk_vocab;
        private System.Windows.Forms.Button btn_func_action;
        private System.Windows.Forms.Label lbl_search_result;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lbl_init_state_info;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

