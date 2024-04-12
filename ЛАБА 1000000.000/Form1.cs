namespace ЛАБА_1000000._000
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string xcord = this.textBox1.Text;
            textBox1.Text = xcord;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string ycord = this.textBox2.Text;
            textBox2.Text = ycord;
        }

        public bool Check_cords()
        { 
            if ((Convert.ToDouble(textBox1.Text) < 0) && (Convert.ToDouble(textBox2.Text) < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(textBox1.Text) > 0) && (Convert.ToDouble(textBox2.Text) > 0))
            {
                double diag = Math.Sqrt(Math.Pow(Convert.ToDouble(textBox2.Text), 2) + Math.Pow(Convert.ToDouble(textBox1.Text), 2));
                double sin = Convert.ToDouble(textBox1.Text) / diag;
                double arcsin = Math.Asin(sin);
                textBox3.Text = arcsin.ToString();
            }
            else
            {
                string err = "Введите значения для 1-ой четверти";
                textBox3.Text = err;
            }
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}