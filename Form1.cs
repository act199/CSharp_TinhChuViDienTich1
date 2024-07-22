namespace CSharp_TinhChuViDienTich1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dai = Convert.ToDouble(textBox1.Text);
            double rong = Convert.ToDouble(textBox2.Text);
            labKQ.Text = "- Diện tích:" + (dai * rong) + Environment.NewLine + " Chu vi: " + (dai + rong) * 2;
        }
    }
}