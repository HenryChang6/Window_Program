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
        Image current_img = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game_Reset();
        }

        public void Game_Reset()
        {
            PictureBox[] pbs = { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7};
            foreach (PictureBox pb in pbs) pb.BackColor = Color.White;
            current_img = null;
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
                }
            }
        }
        public void CreatePuzzleBoard()
        {
            PictureBox[,] pbs = { { pb0, pb1, pb2 }, { pb3, pb4, pb5 }, { pb6, pb7, pb8 } };
            List<Image> pieces = CutImageIntoPieces(current_img);
            //Hide One piece
            Random rnd = new Random();
            int hidden_index = rnd.Next(0, 9);
            pieces.RemoveAt(hidden_index);
            //Add another 8 into PictureBox
            List<int> indices = Enumerable.Range(0,8).ToList();
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 2) 
                    { 
                        pbs[i, j].Image = null;
                        break;
                    } 
                    int rnd_index = rnd.Next(indices.Count);
                    int target_index = indices[rnd_index];
                    pbs[i,j].Image = pieces[target_index];
                    indices.RemoveAt(rnd_index);
                }
            }
        }

        public List<Image> CutImageIntoPieces(Image img)
        {
            List<Image> pieces = new List<Image>();
            int piece_height = 90, piece_width = 90;
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++) 
                { 
                
                    //syntax: Rectangle(x_cor, y_cor, width, height)
                    Rectangle rec = new Rectangle(piece_width * c, piece_height * r , piece_width, piece_height);
                    Bitmap piece = new Bitmap(piece_width, piece_height);
                    using (Graphics g = Graphics.FromImage(piece))
                    {
                        g.DrawImage(img, 0, 0, rec, GraphicsUnit.Pixel);
                    }
                    pieces.Add(piece);
                }
            }
            return pieces;
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (current_img == null)
            {
                MessageBox.Show("請先選擇圖片!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // timer initialization
            timer1.Enabled = true; timer_min = 0; timer_second = 0;
            // steps initialization
            steps = 0; lbl_steps.Text = $"移動步數:0";
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
