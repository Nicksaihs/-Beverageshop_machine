namespace func
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
        private void maketea(string things)
        {
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.沸水倒進" + things + "\r\n";
            textBox1.Text += "3.茶倒進杯子\r\n";
            textBox1.Text += "4.加檸檬\r\n";
        }
        private void makecoffee()
        {
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.用沸水沖\r\n";
            textBox1.Text += "3.咖啡倒進杯子\r\n";
            textBox1.Text += "4.加糖和牛奶\r\n";
        }

        private void makecoffee(string things, string num)
        {
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.用沸水沖" + things + "\r\n";
            textBox1.Text += "3.咖啡倒進杯子\r\n";
            textBox1.Text += "4.加" + num + "糖和牛奶\r\n";
        }
        private void dumpling()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maketea("h96");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sugar = "無";
            if (radioButton1.Checked == true)
            {
                sugar = "3分";
            }
            else if (radioButton2.Checked == true)
            {
                sugar = "5分";
            }
            else if (radioButton3.Checked == true)
            {
                sugar = "7分";
            }
            else
            {
                sugar = "無";
            }
            makecoffee("coffee", sugar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makecoffee();
        }
    }
}