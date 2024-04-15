namespace prak15
{
    public partial class Form1 : Form
    {
      



        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double c);
            double.TryParse(textBox4.Text, out double d);
            Plus c1 = new Plus(a, b);
            Plus c2 = new Plus(c, d);
            label9.Text = "(a + bi) + (c + di) = (a + c) + (b + d)i";
            

            Plus sum = c1 + c2;
            label3.Text = sum.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double c);
            double.TryParse(textBox4.Text, out double d);
            Plus c1 = new Plus(a, b);
            Plus c2 = new Plus(c, d);

            label9.Text = " (a + bi) - (c + di) = (a - c) + (b - d)i";
            

            Plus sum = c1 - c2;
            label3.Text = sum.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double a);
            double.TryParse(textBox2.Text, out double b);
            double.TryParse(textBox3.Text, out double c);
            double.TryParse(textBox4.Text, out double d);
            Plus c1 = new Plus(a, b);
            Plus c2 = new Plus(c, d);

            label9.Text = " (a + bi) * (c + di) = (a*c - b*d) + (a*d + b*c)i";
            

            Plus sum = c1 * c2;
            label3.Text = sum.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
