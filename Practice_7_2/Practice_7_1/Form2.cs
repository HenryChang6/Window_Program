using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7_1
{
    public partial class Form2 : Form
    {
        public List<string> vocab = new List<string>();
        public List<string> chinese = new List<string>();
        public List<string> category = new List<string>();
        public List<bool> isTag = new List<bool>();
        int rnd_index;
        Random rnd = new Random();
        public Form2(List<string> vocab, List<string>chinese, List<string>category, List<bool> isTag)
        {
            InitializeComponent();
            this.vocab = vocab;
            this.chinese = chinese;
            this.category = category;
            this.isTag = isTag;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(700, 500);
            lbl_category.Text = ""; lbl_chinese.Text = "";
            rnd_index = rnd.Next(0,vocab.Count - 1);
            lbl_vocab.Text = $"單字: {vocab[rnd_index]}";
            if (isTag[rnd_index] == true) cb_isTag.Checked = true;
            else cb_isTag.Checked = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            lbl_chinese.Text = $"中文: {chinese[rnd_index]}";
            lbl_category.Text = $"詞性: {category[rnd_index]}";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(cb_isTag.Checked == true) isTag[rnd_index] = true;
            else isTag[rnd_index] = false;
            rnd_index = rnd.Next(0, vocab.Count - 1);
            lbl_vocab.Text = $"單字: {vocab[rnd_index]}";
            lbl_chinese.Text = ""; lbl_category.Text = "";
            if (isTag[rnd_index] == true) cb_isTag.Checked = true;
            else cb_isTag.Checked = false;
        }
    }
}
