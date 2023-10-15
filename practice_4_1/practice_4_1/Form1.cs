using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_1
{
    public partial class Form1 : Form
    {
        public class Global
        {
            public static int[] pw = new int[4]; 
        }
        public Form1()
        {
            InitializeComponent();
            //clear btn, lbl object
            Button[] btns = { btn1, btn2, btn3, btn4 };
            Label[] lbls = { lbl1, lbl2, lbl3, lbl4 };
            foreach(Button btn in btns)  btn.Text = "";
            foreach(Label lbl in lbls) lbl.Text = "";
            //create imagelist obj 
            Image img;
            ImageList imgList = new ImageList();
            for (int i = 0; i < 10; i++)
            {
                img = Image.FromFile($"{i}.jpg");
                imgList.Images.Add( img );
            }
            imgList.ImageSize = new Size(104,130);
            //initialize the btns 
            btn1.ImageList = imgList;
            btn1.ImageIndex = 0;
            btn2.ImageList = imgList;
            btn2.ImageIndex = 0;
            btn3.ImageList = imgList;
            btn3.ImageIndex = 0;
            btn4.ImageList = imgList;
            btn4.ImageIndex = 0;

            // let btn don't get focus by tab (also not in intial state)
            btn1.TabStop = false;
            btn2.TabStop = false;
            btn3.TabStop = false;
            btn4.TabStop = false;

            //initialize pw
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                Global.pw[i] = rnd.Next(0, 9);
            }
        }

        static public int click_handler(int current)
        {
            return (current == 9 ? 0 : current+1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.ImageIndex = click_handler(btn1.ImageIndex);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.ImageIndex = click_handler(btn2.ImageIndex);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.ImageIndex = click_handler(btn3.ImageIndex);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.ImageIndex = click_handler(btn4.ImageIndex);
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            bool digit1 = false, digit2 = false, digit3 = false, digit4 = false;
            int right_counting = 0;
            if (Global.pw[0] == btn1.ImageIndex) { digit1 = true; right_counting++; }
            if (Global.pw[1] == btn2.ImageIndex) { digit2 = true; right_counting++; }
            if (Global.pw[2] == btn3.ImageIndex) { digit3 = true; right_counting++; }
            if (Global.pw[3] == btn4.ImageIndex) { digit4 = true; right_counting++; }
            // right
            if (digit1 && digit2 && digit3 && digit4)
            {
                Label[] lbls = { lbl1, lbl2, lbl3, lbl4 };
                foreach (Label lbl in lbls) lbl.Text = "";
                MessageBox.Show("解鎖成功","成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            //false
            else
            {
                lbl1.Text = digit1 ? "對" : "錯";
                lbl2.Text = digit2 ? "對" : "錯";
                lbl3.Text = digit3 ? "對" : "錯";
                lbl4.Text = digit4 ? "對" : "錯";
                DialogResult result = MessageBox.Show($"猜對{right_counting}個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result == DialogResult.Cancel)
                {
                    MessageBox.Show($"答案是{Global.pw[0]}{Global.pw[1]}{Global.pw[2]}{Global.pw[3]}");
                }
            }

        }
    }
}
