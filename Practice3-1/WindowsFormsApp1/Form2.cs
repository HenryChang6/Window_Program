using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string name, string gender, string date, string birth, string animal)
        {
            InitializeComponent();
            String[] analysis = { "桃花運大漲", "家庭遭逢變故", "事業平步青雲，有升官可能", "事業起伏大", "親人病情好轉", "被財神眷顧", "近期一帆風順" };

            String[] suggest = { "少做壞事，夜路走多了\n總匯三明治",
                     "保持謙虛，一山還有一山高，\n雞蛋還有雞蛋糕",
                     "善待他人，不要任意嘲笑別人，\n除非你忍不住",
                     "早點睡覺，不要仗著自己長得醜，\n就任意熬夜",
                     "小心小人，可謂浮雲能蔽日，\n輕舟已過萬重山",
                     "不要偷懶，你在睡覺的時候，\n美國人還在上班阿",
                     "健康第一，定期身體檢查並謹記\n醫生怎麼說，doctor!",
                     "穩定情緒，今天不開心沒關係，\n反正明天也不會開心"};
            Random rnd = new Random();
            lbl2_luck.Text = "運勢:" + analysis[rnd.Next(0,7)];
            lbl2_suggestion.Text = "建議:" + suggest[rnd.Next(0,7)];
            lbl2_name.Text += "\n" + name;
            lbl2_gender.Text += "\n" + gender;
            lbl2_date.Text += "\n" + date;
            lbl2_birth.Text += "\n" + birth;
            lbl2_animal.Text += "\n" + animal;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
