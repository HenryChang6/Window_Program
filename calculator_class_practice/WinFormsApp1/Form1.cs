namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Double money = double.Parse(txtCapi.Text);
            Double years = double.Parse(txtYear.Text);
            Double yrate = double.Parse(txtRate.Text);
            Double total;
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = " accumulated amount = NT$ " + total.ToString("#,#.0") + " ¤¸"; label4.Text += "\n Total interest = NT$ " + (total - money).ToString("#,#.0") + " ¤¸";
        }
    }
}