namespace Calculator
{
    public partial class Calculadora : Form
    {

        private string numberOne;
        private string numberTwo;
        private string symbol;

        private string result;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Número 0
        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                if (symbol == null)
                {

                    if (numberOne != null)
                    {
                        numberOne += "0";
                        Result.Text += "0";
                    }
                    else
                    {
                        if (numberTwo != null)
                        {
                            numberTwo += "0";
                            Result.Text += "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                if (numberOne != null)
                {
                    numberOne += ",";
                }
                else
                {
                    numberTwo += ",";
                }
            }

            Result.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (symbol == null && Result.Text != null)
            {
                symbol = "-";
                Result.Text += " - ";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            symbol = null;
            numberOne = null;
            numberTwo = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 3;
            }
            else
            {
                numberTwo += 3;
            }
            Result.Text += "3";
        }

        // Número 7
        private void button1_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 7;
            }
            else
            {
                numberTwo += 7;
            }
            Result.Text += "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (symbol == null && Result.Text != null)
            {
                symbol = "+";
                Result.Text += " + ";

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            double answer = 0;

            switch (symbol)
            {
                case "+":
                    answer = double.Parse(numberOne) + double.Parse(numberTwo);
                    Result.Text = $"{answer}";

                    numberOne = answer.ToString();
                    symbol = null;
                    numberTwo = null;
                    break;
                case "-":
                    answer = double.Parse(numberOne) - double.Parse(numberTwo);
                    Result.Text = $"{answer}";
                    numberOne = answer.ToString();
                    symbol = null;
                    numberTwo = null;
                    break;
                case "*":
                    answer = double.Parse(numberOne) * double.Parse(numberTwo);
                    Result.Text = $"{answer}";

                    numberOne = answer.ToString();
                    symbol = null;
                    numberTwo = null;
                    break;
                case "/":
                    answer = double.Parse(numberOne) / double.Parse(numberTwo);
                    Result.Text = $"{answer}";

                    numberOne = answer.ToString();
                    symbol = null;
                    numberTwo = null;
                    break;
                case "^":
                    answer = Math.Pow(double.Parse(numberOne), double.Parse(numberTwo));
                    Result.Text = $"{answer}";

                    numberOne = answer.ToString();
                    symbol = null;
                    numberTwo = null;
                    break;
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 8;
            }
            else
            {
                numberTwo += 8;
            }
            Result.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 9;
            }
            else
            {
                numberTwo += 9;
            }
            Result.Text += "9";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 4;
            }
            else
            {
                numberTwo += 4;
            }
            Result.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 5;
            }
            else
            {
                numberTwo += 5;
            }
            Result.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 6;
            }
            else
            {
                numberTwo += 6;
            }
            Result.Text += "6";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 1;
            }
            else
            {
                numberTwo += 1;
            }
            Result.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (symbol == null)
            {
                numberOne += 2;
            }
            else
            {
                numberTwo += 2;
            }
            Result.Text += "2";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (symbol == null && Result.Text != null)
            {
                symbol = "*";
                Result.Text += " * ";

            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (symbol == null && Result.Text != null)
            {
                symbol = "/";
                Result.Text += " / ";

            }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            if (symbol == null && Result.Text != null)
            {
                symbol = "^";
                Result.Text += " ^ ";

            }
        }
    }
}