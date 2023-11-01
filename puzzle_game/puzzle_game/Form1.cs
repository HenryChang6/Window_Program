using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle_game
{
    public partial class Form1 : Form
    {
        string imagePath;
        int timer_min = 0, timer_second = 0;
        string timer_str_min, timer_str_second;
        int steps = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_choose_photo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "選擇一個圖片檔案";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                    imagePath = filePath;  // Assuming imagePath is a class-level variable
                    trackbar_diaplay.Value = 1;
                }
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            // timer initialization
            timer1.Enabled = true; timer_min = 0; timer_second = 0;
            // steps initialization
            steps = 0; lbl_steps.Text = $"移動步數:0";
        }
        public void Update_Steps()
        {
            lbl_steps.Text = $"移動步數:{++steps}";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_second += 1;
            if (timer_second == 60)
            {
                timer_second = 0;
                timer_min += 1;
            }

            Timer_String_Converter();
            lbl_time.Text = $"時間: {timer_str_min}:{timer_str_second}";
        }

        public void Timer_String_Converter()
        {
            timer_str_min = timer_min < 10 ? timer_str_min = $"0{timer_min}" : timer_str_min = $"{timer_min}";
            timer_str_second = timer_second < 10 ? timer_str_second = $"0{timer_second}" : timer_str_second = $"{timer_second}";
        }

        private void trackbar_diaplay_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = trackbar_diaplay.Value == 0 ? null : Image.FromFile(imagePath);
        }
    }
}
