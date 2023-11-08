using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6_2
{
    public partial class Form1 : Form
    {
        bool isAlarmSet = false;
        DateTime alarm_time;
        Timer check_timer = new Timer();
        string sound_path = null;
        SoundPlayer soundPlayer;
        List<int>[] display_index = new List<int>[10] {
            new List<int> { 1, 2, 3, 5, 9, 10, 14, 20, 24, 25, 29, 31, 32, 33 },
            new List<int> { 9, 14, 24, 29 },
            new List<int> { 1, 2, 3, 9, 14, 16, 17, 18, 20, 25, 31, 32, 33 },
            new List<int> { 1, 2, 3, 9, 14, 16, 17, 18, 24, 29, 31, 32, 33 },
            new List<int> { 5, 9, 10, 14, 16, 17, 18, 24, 29 },
            new List<int> { 1, 2, 3, 5, 10, 16, 17, 18, 24, 29, 31, 32, 33 },
            new List<int> { 1, 2, 3, 5, 10, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 },
            new List<int> { 1, 2, 3, 9, 14, 24, 29 },
            new List<int> { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 },
            new List<int> { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 24, 29, 31, 32, 33 }
        };
        PictureBox[,] unit_cell = new PictureBox[6, 35];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_record.Text = "";
            dateTimePicker.CustomFormat = "tt hh:mm";
            check_timer.Interval = 1000;
            check_timer.Tick += check_timer_Tick;
            //Init Time Monitor
            for(int i=0; i < 6; i++)
            {
                for(int j=0; j < 35; j++)
                {
                    unit_cell[i,j] = new PictureBox();
                    unit_cell[i, j].Size = new Size(25, 25);
                    unit_cell[i, j].Location = new Point(30 + i*150 + (j%5) * 25, 30 + (j/5) * 25 );
                    unit_cell[i, j].Name = $"unit_{i}_{j}";
                    unit_cell[i,j].BackColor = Color.White;
                    unit_cell[i,j].BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(unit_cell[i, j]);
                }
            }
            timer_update.Enabled = true;
        }

        private void btn_set_alarm_Click(object sender, EventArgs e)
        {
            if (!isAlarmSet)
            {
                if(sound_path == null)
                {
                    MessageBox.Show("請先設定鬧鈴", "", MessageBoxButtons.OK);
                    lbl_record.Text += $"{DateTime.Now}:錯誤訊息!\n";
                    return;
                }
                alarm_time = dateTimePicker.Value;
                if (alarm_time < DateTime.Now) alarm_time = alarm_time.AddDays(1);
                check_timer.Start();
                lbl_record.Text += $"{DateTime.Now}:已設定鬧鐘\n";
                btn_set_alarm.Text = "停止";  isAlarmSet = true;
            }
            else
            {
                if(soundPlayer!=null) soundPlayer.Stop();
                lbl_record.Text += $"{DateTime.Now}:已關閉鬧鐘\n";
                check_timer.Stop();
                btn_set_alarm.Text = "啟動";  isAlarmSet = false;
            }
        }

        private void check_timer_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now >= alarm_time)
            {
                check_timer.Stop();
                lbl_record.Text += $"{DateTime.Now}:鬧鐘響鈴!\n";
                soundPlayer = new SoundPlayer(sound_path);
                soundPlayer.PlayLooping();
                MessageBox.Show("時間到!該起床囉~", "", MessageBoxButtons.OK);
            }
        }

        private void btn_choose_sound_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ODF = new OpenFileDialog())
            {
                ODF.Filter = "音樂檔案(*.mp3;*.wav)|*.mp3;*.wav|所有檔案(*.*)|*.*";
                ODF.Title = "選擇一個音樂檔案";
                if(ODF.ShowDialog() == DialogResult.OK)
                {
                    sound_path = ODF.FileName;
                    lbl_sound_path.Text = ODF.FileName;
                    lbl_record.Text += $"{DateTime.Now}:已設定鬧鈴\n";
                }
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                SFD.Title = "保存文件";

                if(SFD.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(SFD.FileName, lbl_record.Text);
                    lbl_record.Text += $"{DateTime.Now}:已匯出記錄檔";
                }
            }
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("hhmmss");
            for(int i = 0; i < 6; i++)
            {
                int num = (int) Char.GetNumericValue(s[i]);
                for (int j = 0; j < 35; j++)
                {
                    if (display_index[num].Contains(j)) unit_cell[i,j].BackColor = Color.Blue;
                    else unit_cell[i,j].BackColor = Color.White;
                }
            }
            string ss = DateTime.Now.ToString("tt");
            if (ss == "AM") lbl_AMorPM.Text = "上午";
            else lbl_AMorPM.Text = "下午";
        }
    }
}
