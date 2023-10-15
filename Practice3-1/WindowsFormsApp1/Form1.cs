using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_error_animal.Text = "";
            lbl_error_gender.Text = "";
            lbl_error_birth.Text = "";
        }

        private void tb_gender_Enter(object sender, EventArgs e)
        {
            if(tb_gender.Text == "男or女")
            {
                tb_gender.Text = "";
                tb_gender.ForeColor = Color.Black;
            }
        }

        private void tb_gender_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_gender.Text))
            {
                tb_gender.Text = "男or女";
                tb_gender.ForeColor = SystemColors.ControlDark;
            }
        }

        private void tb_birth_Enter(object sender, EventArgs e)
        {
            if (tb_birth.Text == "格式為xxxx/xx/xx")
            {
                tb_birth.Text = "";
                tb_birth.ForeColor = Color.Black;
            }
        }

        private void tb_birth_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_birth.Text))
            {
                tb_birth.Text = "格式為xxxx/xx/xx";
                tb_birth.ForeColor = SystemColors.ControlDark;
            }
        }

        private void tb_date_Enter(object sender, EventArgs e)
        {
            if (tb_date.Text == "格式為xxxx/xx/xx")
            {
                tb_date.Text = "";
                tb_date.ForeColor = Color.Black;
            }
        }

        private void tb_date_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_date.Text))
            {
                tb_date.Text = "格式為xxxx/xx/xx";
                tb_date.ForeColor = SystemColors.ControlDark;
            }
        }

        private void tb_animal_Enter(object sender, EventArgs e)
        {
            if (tb_animal.Text == "貓or狗")
            {
                tb_animal.Text = "";
                tb_animal.ForeColor = Color.Black;
            }
        }

        private void tb_animal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_animal.Text))
            {
                tb_animal.Text = "貓or狗";
                tb_animal.ForeColor = SystemColors.ControlDark;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //validate input
            bool isErrorOccur = false;
            if (tb_gender.Text != "男" && tb_gender.Text != "女")
            {
                isErrorOccur = true;
                lbl_error_gender.Text = "輸入應為男or女";
            }
            if (tb_birth.Text == "格式為xxxx/xx/xx")
            {
                isErrorOccur = true;
                lbl_error_birth.Text = "此欄未填寫";
            }
            if (tb_animal.Text != "貓" && tb_animal.Text != "狗")
            {
                isErrorOccur = true;
                lbl_error_animal.Text = "輸入應為貓or狗";
            }
            //if input is ligit, then show the result
            if (!isErrorOccur)
            {
                Form2 form2 = new Form2(tb_name.Text, tb_gender.Text, tb_date.Text, tb_birth.Text, tb_animal.Text);
                this.Hide();
                form2.ShowDialog();
                this.Show();
                isErrorOccur = false;
                //要把其他咚東清空
                lbl_error_animal.Text = "";
                lbl_error_gender.Text = "";
                lbl_error_birth.Text = "";
                tb_animal.Text = "貓or狗";
                tb_animal.ForeColor = SystemColors.ControlDark;
                tb_birth.Text = "格式為xxxx/xx/xx";
                tb_birth.ForeColor = SystemColors.ControlDark;
                tb_date.Text = "格式為xxxx/xx/xx";
                tb_date.ForeColor = SystemColors.ControlDark;
                tb_name.Text = "";
                tb_name.ForeColor = SystemColors.ControlDark;
                tb_gender.Text = "男or女";
                tb_gender.ForeColor = SystemColors.ControlDark;
            }
        }
    }
}
