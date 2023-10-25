namespace Practie_5_2
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_game_phase_1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_choose_saber = new System.Windows.Forms.Button();
            this.btn_choose_caster = new System.Windows.Forms.Button();
            this.btn_choose_berserker = new System.Windows.Forms.Button();
            this.lbl_game_phase_2 = new System.Windows.Forms.Label();
            this.btn_attack = new System.Windows.Forms.Button();
            this.btn_skill = new System.Windows.Forms.Button();
            this.btn_baoG = new System.Windows.Forms.Button();
            this.lbl_player_name = new System.Windows.Forms.Label();
            this.lbl_beast_name = new System.Windows.Forms.Label();
            this.lbl_player_hp = new System.Windows.Forms.Label();
            this.lbl_player_charge = new System.Windows.Forms.Label();
            this.lbl_player_attack = new System.Windows.Forms.Label();
            this.lbl_beast_hp = new System.Windows.Forms.Label();
            this.lbl_beast_charge = new System.Windows.Forms.Label();
            this.lbl_beast_attack = new System.Windows.Forms.Label();
            this.lbl_turn_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(542, 424);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(368, 86);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "開始遊戲";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_game_phase_1
            // 
            this.lbl_game_phase_1.AutoSize = true;
            this.lbl_game_phase_1.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_game_phase_1.Location = new System.Drawing.Point(649, 43);
            this.lbl_game_phase_1.Name = "lbl_game_phase_1";
            this.lbl_game_phase_1.Size = new System.Drawing.Size(169, 38);
            this.lbl_game_phase_1.TabIndex = 1;
            this.lbl_game_phase_1.Text = "準備階段";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_timer.Location = new System.Drawing.Point(708, 104);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(51, 37);
            this.lbl_timer.TabIndex = 3;
            this.lbl_timer.Text = "10";
            // 
            // btn_choose_saber
            // 
            this.btn_choose_saber.Location = new System.Drawing.Point(350, 213);
            this.btn_choose_saber.Name = "btn_choose_saber";
            this.btn_choose_saber.Size = new System.Drawing.Size(202, 78);
            this.btn_choose_saber.TabIndex = 5;
            this.btn_choose_saber.Text = "Saber";
            this.btn_choose_saber.UseVisualStyleBackColor = true;
            this.btn_choose_saber.Click += new System.EventHandler(this.btn_choose_saber_Click);
            // 
            // btn_choose_caster
            // 
            this.btn_choose_caster.Location = new System.Drawing.Point(628, 213);
            this.btn_choose_caster.Name = "btn_choose_caster";
            this.btn_choose_caster.Size = new System.Drawing.Size(202, 78);
            this.btn_choose_caster.TabIndex = 6;
            this.btn_choose_caster.Text = "Caster";
            this.btn_choose_caster.UseVisualStyleBackColor = true;
            this.btn_choose_caster.Click += new System.EventHandler(this.btn_choose_caster_Click);
            // 
            // btn_choose_berserker
            // 
            this.btn_choose_berserker.Location = new System.Drawing.Point(899, 213);
            this.btn_choose_berserker.Name = "btn_choose_berserker";
            this.btn_choose_berserker.Size = new System.Drawing.Size(202, 78);
            this.btn_choose_berserker.TabIndex = 7;
            this.btn_choose_berserker.Text = "Berserker";
            this.btn_choose_berserker.UseVisualStyleBackColor = true;
            this.btn_choose_berserker.Click += new System.EventHandler(this.btn_choose_berserker_Click);
            // 
            // lbl_game_phase_2
            // 
            this.lbl_game_phase_2.AutoSize = true;
            this.lbl_game_phase_2.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbl_game_phase_2.Location = new System.Drawing.Point(690, 43);
            this.lbl_game_phase_2.Name = "lbl_game_phase_2";
            this.lbl_game_phase_2.Size = new System.Drawing.Size(93, 38);
            this.lbl_game_phase_2.TabIndex = 8;
            this.lbl_game_phase_2.Text = "時間";
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(350, 213);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(202, 78);
            this.btn_attack.TabIndex = 9;
            this.btn_attack.Text = "普攻";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.game_btn_Click);
            // 
            // btn_skill
            // 
            this.btn_skill.Location = new System.Drawing.Point(628, 213);
            this.btn_skill.Name = "btn_skill";
            this.btn_skill.Size = new System.Drawing.Size(202, 78);
            this.btn_skill.TabIndex = 10;
            this.btn_skill.Text = "技能";
            this.btn_skill.UseVisualStyleBackColor = true;
            this.btn_skill.Click += new System.EventHandler(this.game_btn_Click);
            // 
            // btn_baoG
            // 
            this.btn_baoG.Location = new System.Drawing.Point(899, 213);
            this.btn_baoG.Name = "btn_baoG";
            this.btn_baoG.Size = new System.Drawing.Size(202, 78);
            this.btn_baoG.TabIndex = 11;
            this.btn_baoG.Text = "寶具";
            this.btn_baoG.UseVisualStyleBackColor = true;
            this.btn_baoG.Click += new System.EventHandler(this.game_btn_Click);
            // 
            // lbl_player_name
            // 
            this.lbl_player_name.AutoSize = true;
            this.lbl_player_name.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_player_name.Location = new System.Drawing.Point(73, 152);
            this.lbl_player_name.Name = "lbl_player_name";
            this.lbl_player_name.Size = new System.Drawing.Size(166, 43);
            this.lbl_player_name.TabIndex = 12;
            this.lbl_player_name.Text = "character";
            // 
            // lbl_beast_name
            // 
            this.lbl_beast_name.AutoSize = true;
            this.lbl_beast_name.Font = new System.Drawing.Font("新細明體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_beast_name.Location = new System.Drawing.Point(1211, 152);
            this.lbl_beast_name.Name = "lbl_beast_name";
            this.lbl_beast_name.Size = new System.Drawing.Size(109, 43);
            this.lbl_beast_name.TabIndex = 13;
            this.lbl_beast_name.Text = "Beast";
            // 
            // lbl_player_hp
            // 
            this.lbl_player_hp.AutoSize = true;
            this.lbl_player_hp.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_player_hp.Location = new System.Drawing.Point(73, 213);
            this.lbl_player_hp.Name = "lbl_player_hp";
            this.lbl_player_hp.Size = new System.Drawing.Size(166, 43);
            this.lbl_player_hp.TabIndex = 14;
            this.lbl_player_hp.Text = "character";
            // 
            // lbl_player_charge
            // 
            this.lbl_player_charge.AutoSize = true;
            this.lbl_player_charge.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_player_charge.Location = new System.Drawing.Point(73, 274);
            this.lbl_player_charge.Name = "lbl_player_charge";
            this.lbl_player_charge.Size = new System.Drawing.Size(166, 43);
            this.lbl_player_charge.TabIndex = 15;
            this.lbl_player_charge.Text = "character";
            // 
            // lbl_player_attack
            // 
            this.lbl_player_attack.AutoSize = true;
            this.lbl_player_attack.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_player_attack.Location = new System.Drawing.Point(73, 338);
            this.lbl_player_attack.Name = "lbl_player_attack";
            this.lbl_player_attack.Size = new System.Drawing.Size(166, 43);
            this.lbl_player_attack.TabIndex = 16;
            this.lbl_player_attack.Text = "character";
            // 
            // lbl_beast_hp
            // 
            this.lbl_beast_hp.AutoSize = true;
            this.lbl_beast_hp.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_beast_hp.Location = new System.Drawing.Point(1211, 214);
            this.lbl_beast_hp.Name = "lbl_beast_hp";
            this.lbl_beast_hp.Size = new System.Drawing.Size(166, 43);
            this.lbl_beast_hp.TabIndex = 17;
            this.lbl_beast_hp.Text = "character";
            // 
            // lbl_beast_charge
            // 
            this.lbl_beast_charge.AutoSize = true;
            this.lbl_beast_charge.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_beast_charge.Location = new System.Drawing.Point(1211, 274);
            this.lbl_beast_charge.Name = "lbl_beast_charge";
            this.lbl_beast_charge.Size = new System.Drawing.Size(166, 43);
            this.lbl_beast_charge.TabIndex = 18;
            this.lbl_beast_charge.Text = "character";
            // 
            // lbl_beast_attack
            // 
            this.lbl_beast_attack.AutoSize = true;
            this.lbl_beast_attack.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_beast_attack.Location = new System.Drawing.Point(1211, 338);
            this.lbl_beast_attack.Name = "lbl_beast_attack";
            this.lbl_beast_attack.Size = new System.Drawing.Size(166, 43);
            this.lbl_beast_attack.TabIndex = 19;
            this.lbl_beast_attack.Text = "character";
            // 
            // lbl_turn_info
            // 
            this.lbl_turn_info.AutoSize = true;
            this.lbl_turn_info.Font = new System.Drawing.Font("新細明體", 16F);
            this.lbl_turn_info.Location = new System.Drawing.Point(633, 657);
            this.lbl_turn_info.Name = "lbl_turn_info";
            this.lbl_turn_info.Size = new System.Drawing.Size(197, 43);
            this.lbl_turn_info.TabIndex = 20;
            this.lbl_turn_info.Text = "Caster turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 729);
            this.Controls.Add(this.lbl_turn_info);
            this.Controls.Add(this.lbl_beast_attack);
            this.Controls.Add(this.lbl_beast_charge);
            this.Controls.Add(this.lbl_beast_hp);
            this.Controls.Add(this.lbl_player_attack);
            this.Controls.Add(this.lbl_player_charge);
            this.Controls.Add(this.lbl_player_hp);
            this.Controls.Add(this.lbl_beast_name);
            this.Controls.Add(this.lbl_player_name);
            this.Controls.Add(this.btn_baoG);
            this.Controls.Add(this.btn_skill);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.lbl_game_phase_2);
            this.Controls.Add(this.btn_choose_berserker);
            this.Controls.Add(this.btn_choose_caster);
            this.Controls.Add(this.btn_choose_saber);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_game_phase_1);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_game_phase_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_choose_saber;
        private System.Windows.Forms.Button btn_choose_caster;
        private System.Windows.Forms.Button btn_choose_berserker;
        private System.Windows.Forms.Label lbl_game_phase_2;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.Button btn_skill;
        private System.Windows.Forms.Button btn_baoG;
        private System.Windows.Forms.Label lbl_player_name;
        private System.Windows.Forms.Label lbl_beast_name;
        private System.Windows.Forms.Label lbl_player_hp;
        private System.Windows.Forms.Label lbl_player_charge;
        private System.Windows.Forms.Label lbl_player_attack;
        private System.Windows.Forms.Label lbl_beast_hp;
        private System.Windows.Forms.Label lbl_beast_charge;
        private System.Windows.Forms.Label lbl_beast_attack;
        private System.Windows.Forms.Label lbl_turn_info;
    }
}

