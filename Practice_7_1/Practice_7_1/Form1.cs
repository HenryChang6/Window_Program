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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ToolStripMenuItem new_Item = new ToolStripMenuItem("測試");
            //menuStrip1.Items.Add(new_Item);
            //ToolStripMenuItem sub_item1 = new ToolStripMenuItem("副標1");
            //ToolStripMenuItem sub_item2 = new ToolStripMenuItem("副標2");
            //new_Item.DropDownItems.AddRange(new ToolStripItem[] {sub_item1,sub_item2});
            lbl_content.Text = "";  lbl_search_result.Text = "";
            panel_chk.Hide();  panel_wb.Hide(); lbl_init_state_info.Hide();
        }

        private void menu_search_word_Click(object sender, EventArgs e)
        {
            menu_search_word.Text = "搜尋單字(v)";  menu_add_word.Text = "新增單字";
            panel_chk.Show();  panel_wb.Show();  btn_func_action.Text = "搜尋";
            lbl_search_result.Text = "";  lbl_search_result.Show(); lbl_content.Hide();

        }

        private void menu_add_word_Click(object sender, EventArgs e)
        {
            menu_search_word.Text = "搜尋單字";  menu_add_word.Text = "新增單字(v)";
            panel_wb.Show();  panel_chk.Hide();  btn_func_action.Text = "新增";
            lbl_search_result.Hide(); lbl_content.Show();
        }

        private void btn_func_action_Click(object sender, EventArgs e)
        {
            if(btn_func_action.Text == "搜尋")
            {
                string[] content_str = lbl_content.Text.Split('\n');
                int match_counter = 0;
                lbl_search_result.Text = "";
                if (chk_vocab.Checked) match_counter++; if (chk_chinese.Checked) match_counter++; if (chk_category.Checked) match_counter++;
                foreach (string str in content_str)
                {
                    string[] parse_str = str.Split(' '); int counter = 0;
                    if (string.IsNullOrWhiteSpace(str)) continue;
                    if (chk_vocab.Checked && parse_str[0] == tb_vocab.Text && !string.IsNullOrEmpty(tb_vocab.Text)) counter++;
                    if (chk_chinese.Checked && parse_str[1] == tb_chinese.Text && !string.IsNullOrEmpty(tb_chinese.Text)) counter++;
                    if (chk_category.Checked && parse_str[2] == cb_category.Text && !string.IsNullOrEmpty(cb_category.Text)) counter++;
                    if (counter == match_counter && match_counter!=0) lbl_search_result.Text += str + '\n';
                }
            }
            else if(btn_func_action.Text == "新增")
            {
                if(tb_vocab.Text == "" || tb_chinese.Text == "" || cb_category.Text == "")
                {
                    MessageBox.Show("請將三個欄位都填妥再按下新增按鈕","提示",MessageBoxButtons.OK); 
                    return ;
                }
                lbl_content.Text += $"{tb_vocab.Text} {tb_chinese.Text} {cb_category.Text}\n";
                tb_vocab.Text = "";  tb_chinese.Text = "";  cb_category.Text = "";
            }
        }

        private void menu_inspect_Click(object sender, EventArgs e)
        {
            panel_chk.Hide(); panel_wb.Hide(); lbl_search_result.Hide();  lbl_content.Show();
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_content.Font = fontDialog1.Font;  lbl_search_result.Font = fontDialog1.Font;
                lbl_content.ForeColor = fontDialog1.Color; lbl_search_result.ForeColor = fontDialog1.Color;
            }
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            //清空之前的所有資料，以新的狀態開始程式
            lbl_content.Font = lbl_init_state_info.Font;  lbl_search_result.Font = lbl_init_state_info.Font;
            lbl_content.Text = "";  lbl_search_result.Text = "";
            fontDialog1.Reset();
            panel_chk.Hide();  panel_wb.Hide();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Text File(*.txt)|*.txt|Todo File(*.todo)|*.todo|All File(*.*)|*.*";
                OFD.Title = "開啟舊檔";
                if(OFD.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void menu_save_Click(object sender, EventArgs e)
        {

        }

        private void menu_save_as_newFile_Click(object sender, EventArgs e)
        {

        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
