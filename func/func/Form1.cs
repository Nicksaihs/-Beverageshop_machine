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
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�m���˶i" + things + "\r\n";
            textBox1.Text += "3.���˶i�M�l\r\n";
            textBox1.Text += "4.�[�f�c\r\n";
        }
        private void makecoffee()
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�Ϊm���R\r\n";
            textBox1.Text += "3.�@�ح˶i�M�l\r\n";
            textBox1.Text += "4.�[�}�M����\r\n";
        }

        private void makecoffee(string things, string num)
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�Ϊm���R" + things + "\r\n";
            textBox1.Text += "3.�@�ح˶i�M�l\r\n";
            textBox1.Text += "4.�[" + num + "�}�M����\r\n";
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
            string sugar = "�L";
            if (radioButton1.Checked == true)
            {
                sugar = "3��";
            }
            else if (radioButton2.Checked == true)
            {
                sugar = "5��";
            }
            else if (radioButton3.Checked == true)
            {
                sugar = "7��";
            }
            else
            {
                sugar = "�L";
            }
            makecoffee("coffee", sugar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makecoffee();
        }
    }
}