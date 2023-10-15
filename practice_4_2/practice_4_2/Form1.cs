using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public void initialize_bool_value()
        {
            for (int i = 0; i < 12; i++)
            {
                Global.seed_to_crop_water_status[i] = false;
                Global.seed_to_crop_fertalizer_status[i] = false;
                Global.crop_to_fruit_water_status[i] = false;
                Global.crop_to_fruit_fertalizer_status[i] = false;
            }
        }
        private void Farm_Btn_Click(object sender, EventArgs e)
        {
            // 階段: 空地->灑種子->澆水+施肥 ->作物 -> 澆水+施肥->果實
            // Get the button which is clicked
            Button clicked_button = sender as Button;
            int index = Convert.ToInt32(clicked_button.Name);
            // dirt status
            if (clicked_button.ImageIndex == 0 && rdb_seed.Checked)
            {
                if (Global.seed_amount > 0)
                {
                    clicked_button.ImageIndex = 1;
                    lbl2_seed_amount.Text = $"擁有:{--Global.seed_amount}";
                }
                else 
                    MessageBox.Show("種子用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // seed status
            else if (clicked_button.ImageIndex == 1)
            {
                //fertalizer occasion
                if (rdb_fertalizer.Checked)
                {
                    if(Global.fertalizer_amount > 0) 
                    {
                        lbl2_fertalizer_amount.Text = Global.seed_to_crop_fertalizer_status[index] ? $"擁有{Global.fertalizer_amount}" : $"擁有{--Global.fertalizer_amount}";
                        Global.seed_to_crop_fertalizer_status[index] = true;
                    }
                    else
                        MessageBox.Show("肥料用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //water occasion
                if (rdb_water.Checked) Global.seed_to_crop_water_status[index] = true;
                // check
                if (Global.seed_to_crop_water_status[index] && Global.seed_to_crop_fertalizer_status[index]) clicked_button.ImageIndex = 2;
            }
            //crop status
            else if (clicked_button.ImageIndex == 2)
            { 
                //fertalizer occasion
                if (rdb_fertalizer.Checked)
                {
                    if(Global.fertalizer_amount > 0)
                    {
                        lbl2_fertalizer_amount.Text = Global.crop_to_fruit_fertalizer_status[index] ? $"擁有{Global.fertalizer_amount}" : $"擁有{--Global.fertalizer_amount}";  
                        Global.crop_to_fruit_fertalizer_status[index] = true;
                    }
                    else
                        MessageBox.Show("肥料用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //water occasion
                if (rdb_water.Checked) Global.crop_to_fruit_water_status[index] = true;
                //check
                if (Global.crop_to_fruit_water_status[index] && Global.crop_to_fruit_fertalizer_status[index]) clicked_button.ImageIndex = 3;
            }
            //fruit status
            else if(clicked_button.ImageIndex == 3)
            {
                if (rdb_knife.Checked)
                {
                    lbl2_fruit_amount.Text = $"擁有:{++Global.fruit_amount}";
                    clicked_button.ImageIndex = 0;
                    initialize_bool_value();
                }
            }
        }

        private void btn2_buyNsold_Click(object sender, EventArgs e)
        {
            //handle selling fruits
            if (cb2_fruit.Checked)
            {
                if (Global.fruit_amount != 0)
                {
                    Global.money_left += 40;
                    lbl2_fruit_amount.Text = $"擁有:{--Global.fruit_amount}";
                    lbl2_moneyleft.Text = $"金錢:{Global.money_left}";
                }
            }
            //handle buying seed
            if (cb2_seed.Checked)
            {
                if (Global.money_left >= 10)
                {
                    Global.money_left -= 10;
                    lbl2_seed_amount.Text = $"擁有:{++Global.seed_amount}";
                    lbl2_moneyleft.Text = $"金錢:{Global.money_left}";
                }
            }
            //handle buying fertalizer
            if (cb2_fertalizer.Checked)
            {
                if (Global.money_left >= 10)
                {
                    Global.money_left -= 10;
                    lbl2_fertalizer_amount.Text = $"擁有:{++Global.fertalizer_amount}";
                    lbl2_moneyleft.Text = $"金錢:{Global.money_left}";
                }
            }
        }
         
        public class Global
        {
            public static int seed_amount = 5;
            public static int fertalizer_amount = 5;
            public static int fruit_amount = 0;
            public static int money_left = 100;
            public static bool[] seed_to_crop_water_status = new bool[12];
            public static bool[] seed_to_crop_fertalizer_status = new bool[12];
            public static bool[] crop_to_fruit_water_status = new bool[12];
            public static bool[] crop_to_fruit_fertalizer_status = new bool[12];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // create image list 
            ImageList imglist = new ImageList();
            imglist.Images.Add(Image.FromFile("dirt.jpeg"));
            imglist.Images.Add(Image.FromFile("seed.jpg"));
            imglist.Images.Add(Image.FromFile("crop.jpg"));
            imglist.Images.Add(Image.FromFile("watermelon.jpg"));
            imglist.ImageSize = new Size(100, 100);
            //generate a 3 x 4 button list 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(10 * (i + 1) + i * 100, 10 * (j + 1) + j * 100);
                    btn.Size = new Size(100, 100);
                    btn.Name = $"{j * 3 + i}";
                    btn.ImageList = imglist;
                    btn.ImageIndex = 0;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += Farm_Btn_Click;
                    btn.ImageList.ColorDepth = ColorDepth.Depth32Bit;
                    Page1.Controls.Add(btn);
                }
            }
            //bool value initialize
            initialize_bool_value();
        }
    } 
}
