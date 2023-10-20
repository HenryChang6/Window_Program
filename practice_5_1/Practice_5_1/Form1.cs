using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_5_1
{
    public partial class Form1 : Form
    {
        Button[] btnArray = new Button[36];
        int second = 5;
        int[] right_index = new int[3];
        int[] all_click_index = new int[36];
        int all_click_top = 0;
        string GAME_STATUS = "PREPARE";
        public Form1()
        {
            InitializeComponent();
        }
        public void Init_Btn()
        {
            int xPos = 50;
            int yPos = 145;
            // Initialize each button
            for (int i = 0; i < 36; i++)
            {
                btnArray[i] = new Button();
                btnArray[i].Size = new Size(52, 52);
                btnArray[i].Location = new Point(xPos, yPos);
                if (i <= 9)
                    btnArray[i].Text = Convert.ToString(i);
                else
                    btnArray[i].Text = ((char)('A' + (i - 10))).ToString();

                btnArray[i].Name = $"btn_key_{btnArray[i].Text}";
                Controls.Add(btnArray[i]);
                //update new pos
                if (i == 11 || i == 23)
                {
                    xPos = 50;
                    yPos += (52 + 7);
                }
                else
                    xPos += (52 + 7);
            }
        }
        public void Generate_Random_Right_Key()
        {
            Random rnd = new Random();
            HashSet<int> tmp = new HashSet<int>();
            while(tmp.Count < 3)
                tmp.Add(rnd.Next(0,36));
            right_index = tmp.ToArray();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init_Btn();
            for(int i=0; i<36; i++)
            {
                btnArray[i].Hide();
            }
            lbl_clock.Hide();
            lbl_phase.Hide();
            Generate_Random_Right_Key();
        }
        private void Btn_KeyDown(object sender, KeyEventArgs e)
        {
            int pressed_index = 0;
            if (!((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 65 && e.KeyValue <= 90)))
                return;
            
            for (int i = 0; i < 36; i++)
            {
                if (e.KeyValue == (int)btnArray[i].Text[0])
                {
                    pressed_index = i;
                    break;
                }
            }
            btnArray[pressed_index].BackColor = Color.LightBlue;
            all_click_index[all_click_top++] = pressed_index; 
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 36; i++)
                btnArray[i].Show();
            lbl_clock.Show();
            lbl_phase.Show();
            btn_start.Hide();
            for (int i = 0; i < 3; i++)
                btnArray[right_index[i]].BackColor = Color.LightGreen;
            timer1.Enabled = true;
        }

        public void Reset()
        {
            all_click_top = 0;
            second = 5;
            lbl_clock.Text = "5";
            lbl_phase.Text = "準備階段";
            GAME_STATUS = "PREPARE";
            for (int i = 0; i < 36; i++)
            {
                btnArray[i].Hide();
                btnArray[i].BackColor = Color.White;
            }
            lbl_clock.Hide();
            lbl_phase.Hide();
            btn_start.Show();
            timer1.Enabled = false;
            Generate_Random_Right_Key();
        }

        public bool IsWin()
        {
            bool[] Isright = new bool[3];
            for (int i = 0; i < 3; i++)
                Isright[i] = false;
            for(int i = 0;i < all_click_top; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (all_click_index[i] == right_index[j])
                    {
                        btnArray[all_click_index[i]].BackColor = Color.LightGreen;
                        Isright[j] = true;
                        break;
                    }
                    if(j==2) btnArray[all_click_index[i]].BackColor = Color.Red;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                if (Isright[i] == false)
                    btnArray[right_index[i]].BackColor = Color.Red;
            }
            return ((Isright[0] && Isright[1] && Isright[2]) ? ((all_click_top > 3) ? false : true) : false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = Convert.ToString(second);
            if(second == 0 && GAME_STATUS == "PREPARE")
            {
                GAME_STATUS = "PLAY";
                lbl_phase.Text = "玩家階段";
                second = 5;
                for (int i = 0; i < 3; i++)
                    btnArray[right_index[i]].BackColor = Color.White;
                for (int j = 0; j < 36; j++)
                    btnArray[j].KeyDown += Btn_KeyDown;
                return;
            }
            else if(second == 0 && GAME_STATUS == "PLAY")
            {
                timer1.Enabled = false;
                for (int i = 0; i < 36; i++)
                    btnArray[i].KeyDown -= Btn_KeyDown;
                if (IsWin())
                    MessageBox.Show("You Win!", "",MessageBoxButtons.OK);
                else
                    MessageBox.Show("You Lose!\nTry again!", "", MessageBoxButtons.OK);
                Reset();

            }
            second--;
        }
    }
}
