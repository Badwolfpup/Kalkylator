namespace Kalkylator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        bool plus, minus, gånger, delat, newCalculation = false;
       /* bool minus = false;
        bool gånger = false;
        bool delat = false;
        bool newCalculation = false;*/
        int firstNumber, lastNumber, result;


        private void button1_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (newCalculation)
            {
                textBox1.Text = "";
                newCalculation = false;
            }
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out firstNumber);
            plus = true;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out firstNumber);
            minus = true;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out firstNumber);
            gånger = true;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out firstNumber);
            delat = true;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out lastNumber); 
                
            if (plus)
            {
                result = firstNumber + lastNumber;
                textBox1.Text = result.ToString();
                plus = false;
                newCalculation = true;
            }
            else if (minus)
            {
                result = firstNumber - lastNumber;
                textBox1.Text = result.ToString();
                minus = false;
                newCalculation = true;
            }
            else if (gånger)
            {
                result = firstNumber * lastNumber;
                textBox1.Text = result.ToString();
                gånger = false;
                newCalculation = true;
            }
            else if (delat)
            {
                double division = (double)firstNumber / (double)lastNumber;
                textBox1.Text = division.ToString();
                delat = false;
                newCalculation = true;
            }
        }
    }
}