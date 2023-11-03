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
        Image[] random_imgs = new Image[9];
        Image[] ans_imgs = new Image[9];
        int steps = 0;
        int empty_tag = 8;
        Bitmap current_img = null;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[] pbs = { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7,pb8 };
            foreach (PictureBox pb in pbs)
            {
                if(pb != pb8) pb.BackColor = Color.White;
                pb.Click += Puzzle_Pb_Click;
                //pb.Enabled = false;
            }
            panel1.Enabled = false;

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
                    current_img = new Bitmap(Image.FromFile(filePath), new Size(270, 270));
                    pictureBox1.Image = current_img;
                    imagePath = filePath;  // Assuming imagePath is a class-level variable
                    trackbar_diaplay.Value = 1;

                    for(int i = 0; i < 9; i++)
                    {
                        ans_imgs[i] = current_img.Clone(new Rectangle(i%3 * 90, i/3 * 90 , 90, 90), current_img.PixelFormat);
                    }
                }
            }
        }

        public void CreatePuzzleBoard()
        {
            PictureBox[] pbs = {pb0,pb1,pb2,pb3,pb4,pb5,pb6,pb7,pb8};
            List<int> indices = Enumerable.Range(0, 9).ToList();
            for (int i = 0; i < 9; i++)
            {
                    int rnd_index = rnd.Next(indices.Count);
                    int target_index = indices[rnd_index];
                    pbs[i].Image = ans_imgs[target_index];
                    pbs[i].Visible = true;
                    random_imgs[i] = ans_imgs[target_index]; 
                    indices.RemoveAt(rnd_index);
            }
            pb8.Visible = false;
            empty_tag = 8;
        }

        public void Puzzle_Pb_Click(object sender, EventArgs e)
        {
            Update_Steps();
            PictureBox pb = sender as PictureBox;
            PictureBox[] pbs = { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8 };
            int current_tag = Convert.ToInt32(pb.Tag);

            (random_imgs[empty_tag], random_imgs[current_tag]) = (random_imgs[current_tag], random_imgs[empty_tag]);
            pbs[empty_tag].Image = random_imgs[empty_tag];  
            pbs[current_tag].Visible = false;                 
            pbs[empty_tag].Visible = true;
            empty_tag = current_tag;

            if (random_imgs.SequenceEqual(ans_imgs))
            {
                timer1.Enabled = false;
                MessageBox.Show($"你獲勝了!\n完成時間:{timer_str_min}:{timer_str_second}\n移動部數:{steps}", "", MessageBoxButtons.OK);
                panel1.Enabled = false;
                steps = 0; lbl_steps.Text = $"移動步數: {steps}";
                timer_min = 0; timer_second = 0;
                Timer_String_Converter();
                lbl_time.Text = $"時間: {timer_str_min}:{timer_str_second}";
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (current_img == null)
            {
                MessageBox.Show("請先選擇圖片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // timer initialization
            timer1.Enabled = true; timer_min = 0; timer_second = 0;
            // steps initialization
            steps = 0; lbl_steps.Text = $"移動步數:0";
            // picture box initialization
            panel1.Enabled = true;
            // puzzle board initialization
            CreatePuzzleBoard();
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
            if(current_img != null) pictureBox1.Image = trackbar_diaplay.Value == 0 ? null : current_img;
        }
    }
}
