using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Practie_5_2
{
    public partial class Form1 : Form
    {
        string GAME_STATUS = "PRE";
        Beast beast = new Beast();
        int current_index = 0;
        int death = 0;
        bool one_down = false;
        Servant[] attack_order = new Servant[3];
        Servant current_character => attack_order[current_index];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            To_Start();
        }

        public void To_Start()
        {
            btn_start.Show();
            lbl_game_phase_1.Hide();
            lbl_game_phase_2.Hide();
            lbl_timer.Hide();
            btn_choose_saber.Hide();
            btn_choose_caster.Hide();
            btn_choose_berserker.Hide();
            btn_attack.Hide();
            btn_baoG.Hide();
            btn_skill.Hide();
            lbl_beast_attack.Hide();
            lbl_beast_charge.Hide();
            lbl_beast_hp.Hide();
            lbl_beast_name.Hide();
            lbl_player_attack.Hide();
            lbl_player_charge.Hide();
            lbl_player_hp.Hide();
            lbl_player_name.Hide();
            lbl_turn_info.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GAME_STATUS == "PRE" && MyTimer.count_down == 0)
            {
                //handle no character choosen situation
                ConfirmChooseCharacter();
                //new an object for character1(faster speed) and character2(slower speed)
                Update_Choose_Character();
                Init_Attack_Order();
                Prep_To_Game();
                Prep_To_Game_Text_Init();
            }
            else if (GAME_STATUS == "PRE" && MyTimer.count_down != 0)
            {
                MyTimer.count_down--;
                lbl_timer.Text = Convert.ToString(MyTimer.count_down);
            }
            else if (GAME_STATUS == "GAME")
            {
                MyTimer.game_last_time++;
                lbl_timer.Text = Convert.ToString(MyTimer.game_last_time);
            }
                
        }

        public void Init_Attack_Order() 
        {
            //character 1 一定速度最快 
            attack_order[0] = ChooseCharacter.character1;
            attack_order[1] = (ChooseCharacter.character2.speed < beast.speed ? ChooseCharacter.character2 : beast);
            attack_order[2] = (ChooseCharacter.character2.speed < beast.speed ? beast : ChooseCharacter.character2);
        }

        public void Prep_To_Game()
        {
            GAME_STATUS = "GAME";
            lbl_game_phase_1.Hide();
            lbl_game_phase_2.Show();
            btn_choose_berserker.Hide();
            btn_choose_saber.Hide();
            btn_choose_caster.Hide();
            lbl_beast_attack.Show();
            lbl_beast_charge.Show();
            lbl_beast_hp.Show();
            lbl_beast_name.Show();
            lbl_player_attack.Show();
            lbl_player_charge.Show();
            lbl_player_hp.Show();
            lbl_player_name.Show();
            lbl_turn_info.Show();
            btn_attack.Show();
            btn_baoG.Show();
            btn_skill.Show();
        }

        public void Prep_To_Game_Text_Init()
        {
            lbl_timer.Text = "0";
            lbl_turn_info.Text = $"{ChooseCharacter.character1.character} turn";
            lbl_beast_attack.Text = $"Attack:{beast.atk}";
            lbl_beast_hp.Text = $"HP:{beast.hp}";
            lbl_beast_charge.Text = $"Charge:{beast.charge}%";
            lbl_player_attack.Text = $"Attack:{current_character.atk}";
            lbl_player_hp.Text = $"HP:{current_character.hp}";
            lbl_player_charge.Text = $"Charge:{current_character.charge}%";
            lbl_player_name.Text = $"{current_character.character}";
        }

        public void ConfirmChooseCharacter()
        {
            if(ChooseCharacter.choosen_character == 1)
            {
                if(ChooseCharacter.isBerserkerChoose) ChooseCharacter.isSaberChoose = true;
                else 
                {
                    ChooseCharacter.isSaberChoose = true;
                    ChooseCharacter.isCasterChoose = true;
                }
            }
            else if(ChooseCharacter.choosen_character == 0)
            {
                ChooseCharacter.isSaberChoose = true;
                ChooseCharacter.isCasterChoose = true;
            }
        }

        public void Update_Choose_Character()
        {
            if(ChooseCharacter.isSaberChoose && ChooseCharacter.isCasterChoose)
            {
                ChooseCharacter.character1 = new Saber();
                ChooseCharacter.character2 = new Caster();
            }
            else if(ChooseCharacter.isCasterChoose && ChooseCharacter.isBerserkerChoose)
            {
                ChooseCharacter.character1 = new Caster();
                ChooseCharacter.character2 = new Berserker();
            }
            else if(ChooseCharacter.isSaberChoose && ChooseCharacter.isBerserkerChoose)
            {
                ChooseCharacter.character1 = new Saber();
                ChooseCharacter.character2 = new Berserker();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Hide();
            lbl_game_phase_1.Show();
            lbl_timer.Show();
            btn_choose_berserker.Show();
            btn_choose_caster.Show();
            btn_choose_saber.Show();
            timer1.Enabled = true;
        }


        private void btn_choose_saber_Click(object sender, EventArgs e)
        {
            if(ChooseCharacter.choosen_character == 2 && ChooseCharacter.isSaberChoose == false)
            {
                MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                return;
            }
            if (ChooseCharacter.isSaberChoose)
            {
                btn_choose_saber.BackColor = Color.White;
                ChooseCharacter.isSaberChoose = false;
                ChooseCharacter.choosen_character--;
            }
            else
            {
                btn_choose_saber.BackColor = Color.LightGreen;
                ChooseCharacter.isSaberChoose = true;
                ChooseCharacter.choosen_character++;
            }
        }

        private void btn_choose_caster_Click(object sender, EventArgs e)
        {
            if (ChooseCharacter.choosen_character == 2 && ChooseCharacter.isCasterChoose == false)
            {
                MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                return;
            }
            if (ChooseCharacter.isCasterChoose)
            {
                btn_choose_caster.BackColor = Color.White;
                ChooseCharacter.isCasterChoose = false;
                ChooseCharacter.choosen_character--;
            }
            else
            {
                btn_choose_caster.BackColor = Color.LightGreen;
                ChooseCharacter.isCasterChoose = true;
                ChooseCharacter.choosen_character++;
            }
        }

        private void btn_choose_berserker_Click(object sender, EventArgs e)
        {
            if (ChooseCharacter.choosen_character == 2 && ChooseCharacter.isBerserkerChoose == false)
            {
                MessageBox.Show("只能選兩個Servant!", "", MessageBoxButtons.OK);
                return;
            }
            if (ChooseCharacter.isBerserkerChoose) 
            {
                btn_choose_berserker.BackColor = Color.White;
                ChooseCharacter.isBerserkerChoose = false;
                ChooseCharacter.choosen_character--;
            } 
            else 
            {
                btn_choose_berserker.BackColor = Color.LightGreen;
                ChooseCharacter.isBerserkerChoose = true;
                ChooseCharacter.choosen_character++;
            }
        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            Button clicked_btn = (Button)sender;
            Random rnd = new Random();
            if (!current_character.isDeath)
            {
                switch (clicked_btn.Text)
                {
                    case "普攻":
                        //50%爆擊
                        if (rnd.Next(0, 2) == 0)
                        {
                            beast.hp -= current_character.atk * 2;
                            current_character.charge += 30;
                            Update_Label_4_Player();
                            Update_Label_4_Beast();
                            MessageBox.Show($"對Beast造成了{current_character.atk * 2}點傷害", "", MessageBoxButtons.OK);
                        }
                        else
                        {
                            beast.hp -= current_character.atk;
                            current_character.charge += rnd.Next(20, 25);
                            Update_Label_4_Player();
                            Update_Label_4_Beast();
                            Thread.Sleep(500);
                        }
                        Update_Cd();
                        current_index = (current_index + 1) % 3;
                        if(current_character.isDeath) current_index = (current_index + 1) % 3;
                        if(!(current_character is Beast)) Update_Label_4_Player();
                        break;
                    case "技能":
                        if (current_character.cd == 0)
                        {
                            current_character.Skill();
                            current_character.cd = 2;
                            Update_Label_4_Player();
                            Update_Label_4_Beast();
                            Thread.Sleep(500);
                            MessageBox.Show($"技能冷卻中(剩餘回合:{current_character.cd + 1})", "", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show($"技能冷卻中(剩餘回合:{current_character.cd})", "", MessageBoxButtons.OK);
                        }
                        break;
                    case "寶具":
                        if (current_character.charge >= 100)
                        {
                            current_character.charge -= 100;
                            if (current_character is Saber)
                            {
                                beast.hp -= current_character.atk + 25;
                                current_character.hp += 5;
                                Update_Label_4_Player();
                                Update_Label_4_Beast();
                                MessageBox.Show($"Saber使用了寶具:\n對Beast造成{current_character.atk + 25}點傷害並回覆5點血量", "", MessageBoxButtons.OK);
                            }
                            else if (current_character is Caster)
                            {
                                foreach (Servant servant in attack_order)
                                {
                                    servant.atk += (servant is Beast ? 0 : 1);
                                    servant.hp += (servant is Beast ? 0 : 10);
                                }
                                Update_Label_4_Player();
                                MessageBox.Show($"Caster使用了寶具:\n全體隊友加1點傷害並回覆10點血量", "", MessageBoxButtons.OK);
                            }
                            else if (current_character is Berserker)
                            {
                                beast.hp -= current_character.atk + 50;
                                MessageBox.Show($"Berserker使用了寶具:\n對Beast造成{current_character.atk + 50}點傷害", "", MessageBoxButtons.OK);
                                Update_Label_4_Beast();
                            }
                            Update_Cd();
                            current_index = (current_index + 1) % 3;
                            if (current_character.isDeath) current_index = (current_index + 1) % 3;
                            if (!(current_character is Beast)) Update_Label_4_Player();
                        }
                        else
                        {
                            MessageBox.Show("充能不足，無法施放寶具!", "", MessageBoxButtons.OK);
                        }
                        break;
                }
                //check game status
                if (beast.hp <= 0)
                {
                    timer1.Enabled = false;
                    MessageBox.Show($"You Win!\n通關時間:{MyTimer.game_last_time}", "", MessageBoxButtons.OK);
                    Reset();
                }

                //beast turn
                if (current_character is Beast) Beast_Action();

                Update_Label_4_Player();
                Update_Label_4_Beast();

                //check game status
                foreach (Servant servant in attack_order)
                {
                    if ((!(servant is Beast) && servant.hp <= 0 && !servant.isDeath))
                    {
                        death += 1;
                        one_down = true;
                        servant.isDeath = true;
                        MessageBox.Show($"{servant.character}倒下了!", "", MessageBoxButtons.OK);
                        if (death == 2)
                        {
                            GAME_STATUS = "END";
                            timer1.Enabled = false;
                            MessageBox.Show($"You Lose\n戰鬥時間:{MyTimer.game_last_time}", "", MessageBoxButtons.OK);
                            Reset();
                        }
                        else
                        {
                            current_index = (current_character == servant ? ((current_index + 1) % 3) : current_index);
                            Update_Label_4_Player();
                        }
                    }
                }
            }
            
        }
        
        public void Beast_Action()
        {
            Update_Label_4_Beast();
            if (current_character.cd == 0) { beast.Skill(); beast.cd = 3; } //因為下面cd會被多減一 這邊先設4
            if (current_character.charge >= 100)
            {
                ChooseCharacter.character1.hp -= beast.atk * 2;
                ChooseCharacter.character2.hp -= beast.atk * 2;
                MessageBox.Show($"Beast使用了寶具\n對全體隊友造成{beast.atk * 2}點傷害!", "", MessageBoxButtons.OK);
                current_character.charge -= 100;
                Update_Label_4_Beast();
            }
            else
            {
                ChooseCharacter.character1.hp -= beast.atk;
                ChooseCharacter.character2.hp -= beast.atk;
                MessageBox.Show($"Beast對全體隊友造成{beast.atk}點傷害!", "", MessageBoxButtons.OK);
                beast.charge += 20;
                Update_Label_4_Beast();
            }
            Update_Cd();
            current_index = (current_index + 1) % 3;
            if (current_character.isDeath) current_index = (current_index + 1) % 3;
            Update_Label_4_Player();
            Update_Label_4_Beast();
        } 

        public void Update_Label_4_Beast()
        {
            lbl_beast_hp.Text = $"HP:{beast.hp}";
            lbl_beast_charge.Text = $"Charge:{beast.charge}";
            lbl_beast_attack.Text = $"Attack:{beast.atk}";
            lbl_turn_info.Text = $"{current_character.character} turn";
        }
        public void Update_Label_4_Player()
        {
            lbl_player_name.Text = current_character.character;
            lbl_player_hp.Text = $"HP:{current_character.hp}";
            lbl_player_charge.Text = $"Charge:{current_character.charge}";
            lbl_player_attack.Text = $"Attack:{current_character.atk}";
            lbl_turn_info.Text = $"{current_character.character} turn";
        }
        public void Reset()
        {
            // 重置遊戲時間
            MyTimer.count_down = 10;
            lbl_timer.Text = "10";
            MyTimer.game_last_time = 0;
            timer1.Enabled = false;
            death = 0;
            one_down = false;

            btn_choose_berserker.BackColor = Color.White;
            btn_choose_caster.BackColor = Color.White;
            btn_choose_saber.BackColor = Color.White;

            // 重置選擇的角色
            ChooseCharacter.isSaberChoose = false;
            ChooseCharacter.isCasterChoose = false;
            ChooseCharacter.isBerserkerChoose = false;
            ChooseCharacter.choosen_character = 0;

            // 重置角色屬性
            ChooseCharacter.character1 = new Servant();
            ChooseCharacter.character2 = new Servant(); // 假設您的遊戲中第二個角色是Caster
            current_index = 0;
            

            // 重置敵人屬性
            beast = new Beast();

            // 重置遊戲狀態
            GAME_STATUS = "PRE";
            To_Start();
        }
        
        public void Update_Cd()
        {
            if (current_index + 1 == 3 || (current_index + 1 == 2 && one_down))
            {
                foreach (Servant servant in attack_order)
                {
                    if (!(servant is Beast)) servant.cd = (servant.cd == 0 ? 0 : servant.cd - 1);
                    else servant.cd = (servant.cd == 0 ? 0 : servant.cd - 1);
                }
            }
        }
    }

    static class MyTimer
    {
        static public int count_down = 10;
        static public int game_last_time = 0;
    }

    static class ChooseCharacter
    {
        static public bool isSaberChoose = false;
        static public bool isCasterChoose = false;
        static public bool isBerserkerChoose = false;
        static public int choosen_character = 0;
        static public Servant character1 = new Servant();
        static public Servant character2 = new Servant();
    }

    class Servant
    {
        public string character;
        public int hp;
        public int charge;
        public int atk;
        public int speed;
        public int cd = 2;
        public bool isDeath = false;

        public virtual void Skill() { }
    }

    class Berserker : Servant
    {
        public Berserker()
        {
            character = "Berserker";
            hp = 100;
            charge = 0;
            atk = 4;
            speed = 4;
        }
        public override void Skill()
        {
            atk *= 2;
            hp = hp - hp / 2;
            MessageBox.Show($"{character}使用了技能", "", MessageBoxButtons.OK);
        }
    }
    class Saber : Servant
    {
        public Saber()
        {
            character = "Saber";
            hp = 100;
            charge = 0;
            atk = 3;
            speed = 1;
        }
        public override void Skill()
        {
            atk *= 2;
            MessageBox.Show($"{character}使用了技能", "", MessageBoxButtons.OK);
        }
    }
    class Caster : Servant
    {
        public Caster()
        {
            character = "Caster";
            hp = 100;
            charge = 0;
            atk = 2;
            speed = 2;
        }
        public override void Skill()
        {
            hp += 50;
            MessageBox.Show($"{character}使用了技能", "", MessageBoxButtons.OK);
        }
    }
    class Beast : Servant
    {
        public Beast()
        {
            character = "Beast";
            hp = 500;
            charge = 0;
            atk = 2;
            speed = 3;
            cd = 3;
        }
        public override void Skill()
        {
            atk += 2;
            MessageBox.Show($"Beast使用了技能\n當前ATK:{atk}", "", MessageBoxButtons.OK);
        }
    }
}
