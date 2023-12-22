namespace CALCULATOR1
{
    public partial class Form1 : Form
    {
        private decimal vF = 0.0m;
        private decimal vS = 0.0m;
        private decimal r = 0.0m;
        private string op = "+";
        float n, m;
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            vF = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            op = "-";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            vF = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            op = "+";
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            vF = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            op = "/";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            vF = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            op = "X";
        }

        private void moduleButton_Click(object sender, EventArgs e)
        {
            vF = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            op = "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox1.Text);
            if (n > 0)
            {
                double sqrt = Math.Sqrt(n);
                textBox1.Text = sqrt.ToString();
            }
            op = "rad";
        }
        private void logButton_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox1.Text);
            if(n > 0)
            {
                double log = Math.Log10(n);
                textBox1.Text = log.ToString();
            }
            op = "log";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            n = float.Parse(textBox1.Text);
            double exp1 = Math.Pow(2, n);
            textBox1.Text = exp1.ToString();
            op = "2^n";
        }
        private void puteremareButton_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox1.Text);
            textBox1.Clear();
            op = "x^y";
        }
        private void patratButton_Click(object sender, EventArgs e)
        {
            n = float.Parse(textBox1.Text);
            double exp1 = Math.Pow(n, 2);
            textBox1.Text = exp1.ToString();
            op = "n^2";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "-":
                    vS = decimal.Parse(textBox1.Text);
                    r = vF - vS;
                    textBox1.Text = r.ToString();
                    break;
                case "+":
                    vS = decimal.Parse(textBox1.Text);
                    r = vF + vS;
                    textBox1.Text = r.ToString();
                    break;
                case "X":
                    vS = decimal.Parse(textBox1.Text);
                    r = vF * vS;
                    textBox1.Text = r.ToString();
                    break;
                case "/":
                    vS = decimal.Parse(textBox1.Text);
                    r = vF / vS;
                    textBox1.Text = r.ToString();
                    break;
                case "%":
                    vS = decimal.Parse(textBox1.Text);
                    r = vF % vS;
                    textBox1.Text = r.ToString();
                    break;
                case "rad":
                    n = float.Parse(textBox1.Text);
                    textBox1.Text = Math.Sqrt(n).ToString();
                    break;
                case "log":
                    n = float.Parse(textBox1.Text);
                    textBox1.Text = Math.Log10(n).ToString();
                    break;
                case "2^x":
                    n = float.Parse(textBox1.Text);
                    textBox1.Text = Math.Pow(2, n).ToString();
                    break;
                case "x^y":
                    m = float.Parse(textBox1.Text);
                    textBox1.Text = Math.Pow(n, m).ToString();
                    break;
                case "x^2":
                    n = float.Parse(textBox1.Text);
                    textBox1.Text = Math.Pow(n, 2).ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            vF = 0.0m;
            vS = 0.0m;
            textBox1.Text = "0";
        }
    }

}