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
        Encoding enc = Encoding.UTF8;
        List<bool> isTag = new List<bool>();
        List<string> vocab = new List<string>();
        List<string> chinese = new List<string>();
        List<string> category = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_content.Text = "";  lbl_search_result.Text = ""; lbl_showTag.Text = "";
            panel_chk.Hide();  panel_wb.Hide(); lbl_init_state_info.Hide();
            panel_text.AutoScroll = true;
            panel_text.AutoScrollMinSize = new Size(800,500);
            openFileDialog1.Filter = "Text File(*.txt)|*.txt|Todo File(*.todo)|*.todo|All File(*.*)|*.*";
            openFileDialog1.Title = "開啟舊檔";
            menu_add_word.Click += MenuItem_Click;
            menu_search_word.Click += MenuItem_Click;
            menu_show_tag.Click += MenuItem_Click;
            
        }

        private void menu_search_word_Click(object sender, EventArgs e)
        {
            lbl_showTag.Text = ""; 
            panel_chk.Show();  panel_wb.Show();  btn_func_action.Text = "搜尋";
            panel_text.Size = new Size(521, 423);
            lbl_search_result.Text = "";  lbl_search_result.Show(); lbl_content.Hide(); lbl_showTag.Hide();

        }

        private void menu_add_word_Click(object sender, EventArgs e)
        {
            lbl_showTag.Text = ""; 
            panel_wb.Show();  panel_chk.Hide();  btn_func_action.Text = "新增";
            panel_text.Size = new Size(521, 423);
            lbl_search_result.Hide(); lbl_showTag.Hide(); lbl_content.Show();
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
                vocab.Add(tb_vocab.Text); chinese.Add(tb_chinese.Text); category.Add(cb_category.Text); isTag.Add(false);
                lbl_content.Text += $"{vocab[vocab.Count - 1]} {chinese[chinese.Count - 1]} {category[category.Count - 1]}\n";
                tb_vocab.Text = "";  tb_chinese.Text = "";  cb_category.Text = "";
            }
        }

        private void menu_new_Click(object sender, EventArgs e)
        {
            //清空之前的所有資料，以新的狀態開始程式
            lbl_content.Font = lbl_init_state_info.Font;  lbl_search_result.Font = lbl_init_state_info.Font;
            lbl_content.Text = "";  lbl_search_result.Text = "";
            lbl_showTag.Hide(); lbl_content.Show(); lbl_search_result.Hide();
            panel_text.Size = new Size(761, 423);
            fontDialog1.Reset(); 
            openFileDialog1.FileName = "";
            isTag = new List<bool>();
            panel_chk.Hide();  panel_wb.Hide();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            lbl_showTag.Hide(); lbl_content.Show(); lbl_search_result.Hide();
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    panel_text.Size = new Size(761, 423);
                    string content = System.IO.File.ReadAllText(openFileDialog1.FileName, enc);
                    if (!content.EndsWith(Environment.NewLine) && content[content.Length - 1] != '\n') content += Environment.NewLine;
                    lbl_content.Text = content;
           
                    string []lines = content.Split('\n');
                    isTag = new List<bool>();
                    vocab = new List<string> ();
                    chinese = new List<string> ();
                    category = new List<string>();
                    char[] delimeter = { ' ', '\n' };
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(delimeter);
                        if (parts.Length != 3) continue;
                        vocab.Add(parts[0]);
                        chinese.Add(parts[1]);
                        category.Add(parts[2]); 
                        isTag.Add(false);
                    }
                }
        }

        private void menu_save_Click(object sender, EventArgs e)
        {
            //先檢查目前有沒有開檔 若沒有的話 就當作另存新檔來操作
            if( openFileDialog1.FileName != "")
            {
                try
                {
                    System.IO.File.WriteAllText(openFileDialog1.FileName, lbl_content.Text, enc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法儲存檔案: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else  Save_As_NewFile();

        }

        public void Save_As_NewFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(lbl_showTag.Visible)
                {
                    MessageBox.Show("目前只會存取被標記的單字喔","通知",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, lbl_showTag.Text, enc);
                }
                else System.IO.File.WriteAllText(saveFileDialog1.FileName, lbl_content.Text, enc);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void menu_save_as_newFile_Click(object sender, EventArgs e)
        {
            Save_As_NewFile();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menu_Font_Click(object sender, EventArgs e)
        {
            panel_chk.Hide(); panel_wb.Hide(); lbl_search_result.Hide(); lbl_content.Show();
            lbl_showTag.Text = ""; 
            panel_text.Size = new Size(761, 423);
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_content.Font = fontDialog1.Font; lbl_search_result.Font = fontDialog1.Font;
                lbl_content.ForeColor = fontDialog1.Color; lbl_search_result.ForeColor = fontDialog1.Color;
            }
        }

        private void menu_show_tag_Click(object sender, EventArgs e)
        {
            lbl_content.Hide(); lbl_search_result.Hide(); lbl_showTag.Show();
            lbl_showTag.Text = ""; 
            for (int i = 0; i < vocab.Count - 1; i++) 
            {
                if (isTag[i]) lbl_showTag.Text += $"{vocab[i]} {chinese[i]} {category[i]}\n";
            }
                
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                menu_add_word.Text = menu_add_word.Text.Replace("(v)", "");
                menu_search_word.Text = menu_add_word.Text.Replace("(v)", "");
                menu_search_word.Text = menu_search_word.Text.Replace("(v)","");
                menu_show_tag.Text = menu_show_tag.Text.Replace("(v)","");
                menuItem.Text += "(v)";

            }
        }


        private void menu_clear_tag_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < isTag.Count - 1; i++) isTag[i] = false;
            lbl_showTag.Text = "";
        }

        private void menu_vocab_test_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(vocab, chinese, category, isTag);
            f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
            f2.Show();
            this.Hide();
        }
        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f2 = sender as Form2;
            vocab = f2.vocab;
            chinese = f2.chinese;
            category = f2.category;
            isTag = f2.isTag;
            this.Show();
        }
    }
}
