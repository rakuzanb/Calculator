using System.Security.Cryptography;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value1;
        double value2;
        int you = 0;
        double result = 0;
        string  sign = "" , o = "";
        char exs ;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            sign = "";
            result = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sign = "+";
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";  
            }
            you = 0;
            for (int i = 0; i < textBox2.Text.Length-1; i++)
            {
                if (textBox2.Text[i] == '+')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '-')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '*')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '/')
                {
                    you = 1; break;
                }
            }
            if (you == 1)
            {
                textBox2.Text = Convert.ToString(result) + sign;
                textBox1.Text = "";
            }
            else
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                exs = '?';
                int le = textBox2.Text.Length;
                if (textBox2.Text[le-1] == '+' || textBox2.Text[le - 1] == '-' || textBox2.Text[le - 1] == '*' || textBox2.Text[le - 1] == '*' )
                {
                    exs = textBox2.Text[le - 1];
                    o = "";
                    for (int i = 0; i < le-1; i++)
                    {
                        o = o + textBox2.Text[i];
                    }
                    textBox2.Text = o;                   
                }
                value1 = Convert.ToDouble(textBox2.Text);
                value2 = Convert.ToDouble(textBox1.Text);
                if (exs == '+')
                {
                    result = value1 + value2;
                }
                if (exs == '-')
                {
                    result = value1 - value2;
                }
                if (exs == '*')
                {
                    result = value1 * value2;
                }
                if (exs == '/')
                {
                    result = value1 / value2;
                }
                textBox2.Text = Convert.ToString(result) + "+";
                textBox1.Text = "";
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sign = "*";
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            you = 0;
            for (int i = 0; i < textBox2.Text.Length-1; i++)
            {
                if (textBox2.Text[i] == '+')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '-')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '*')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '/')
                {
                    you = 1; break;
                }
            }
            if (you == 1)
            {
                textBox2.Text = Convert.ToString(result) + sign;
                textBox1.Text = "";
            }
            else
            if (textBox2.Text == "" )
            {
                textBox2.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                exs = '?';
                int le = textBox2.Text.Length;
                if (textBox2.Text[le - 1] == '+' || textBox2.Text[le - 1] == '-' || textBox2.Text[le - 1] == '*' || textBox2.Text[le - 1] == '*')
                {
                    exs = textBox2.Text[le - 1];
                    o = "";
                    for (int i = 0; i < le - 1; i++)
                    {
                        o = o + textBox2.Text[i];
                    }
                    textBox2.Text = o;
                }
                value1 = Convert.ToDouble(textBox2.Text);
                value2 = Convert.ToDouble(textBox1.Text);
                if (exs == '+')
                {
                    result = value1 + value2;
                }
                if (exs == '-')
                {
                    result = value1 - value2;
                }
                if (exs == '*')
                {
                    result = value1 * value2;
                }
                if (exs == '/')
                {
                    result = value1 / value2;
                }
                textBox2.Text = Convert.ToString(result) + "*";
                textBox1.Text = "";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            sign = "/";
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            you = 0;
            for (int i = 0; i < textBox2.Text.Length - 1; i++)
            {
                if (textBox2.Text[i] == '+')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '-')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '*')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '/')
                {
                    you = 1; break;
                }
            }
            if (you == 1)
            {
                textBox2.Text = Convert.ToString(result) + sign;
                textBox1.Text = "";
            }
            else
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                exs = '?';
                int le = textBox2.Text.Length;
                if (textBox2.Text[le - 1] == '+' || textBox2.Text[le - 1] == '-' || textBox2.Text[le - 1] == '*' || textBox2.Text[le - 1] == '*')
                {
                    exs = textBox2.Text[le - 1];
                    o = "";
                    for (int i = 0; i < le - 1; i++)
                    {
                        o = o + textBox2.Text[i];
                    }
                    textBox2.Text = o;
                }
                value1 = Convert.ToDouble(textBox2.Text);
                value2 = Convert.ToDouble(textBox1.Text);
                if (exs == '+')
                {
                    result = value1 + value2;
                }
                if (exs == '-')
                {
                    result = value1 - value2;
                }
                if (exs == '*')
                {
                    result = value1 * value2;
                }
                if (exs == '/')
                {
                    result = value1 / value2;
                }
                textBox2.Text = Convert.ToString(result) + "/";
                textBox1.Text = "";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                exs = '?';
                int le = textBox2.Text.Length;
                if (textBox2.Text[le - 1] == '+' || textBox2.Text[le - 1] == '-' || textBox2.Text[le - 1] == '*' || textBox2.Text[le - 1] == '/')
                {
                    exs = textBox2.Text[le - 1];
                    o = "";
                    for (int i = 0; i < le - 1; i++)
                    {
                        o = o + textBox2.Text[i];
                    }
                    textBox2.Text = o;
                }
                value1 = Convert.ToDouble(textBox2.Text);
                value2 = Convert.ToDouble(textBox1.Text);
                if (exs == '+')
                {
                    result = value1 + value2;
                }
                if (exs == '-')
                {
                    result = value1 - value2;
                }
                if (exs == '*')
                {
                    result = value1 * value2;
                }
                if (exs == '/')
                {
                    result = value1 / value2;
                }
                
                textBox1.Text = Convert.ToString(result);
                if (sign != "")
                {
                    textBox2.Text = Convert.ToDouble(value1) + sign + Convert.ToDouble(value2);
                }
                           
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int yt = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ',')
                {
                    yt++;
                }
            }
            if (yt == 0)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign = "-";
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            you = 0;
            for (int i = 0; i < textBox2.Text.Length - 1; i++)
            {
                if (textBox2.Text[i] == '+')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '-')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '*')
                {
                    you = 1; break;
                }
                if (textBox2.Text[i] == '/')
                {
                    you = 1; break;
                }
            }
            if (you == 1)
            {
                textBox2.Text = Convert.ToString(result) + sign;
                textBox1.Text = "";
            }
            else
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text + sign;
                textBox1.Text = "";
            }
            else
            {
                exs = '?';
                int le = textBox2.Text.Length;
                if (textBox2.Text[le - 1] == '+' || textBox2.Text[le - 1] == '-' || textBox2.Text[le - 1] == '*' || textBox2.Text[le - 1] == '*')
                {
                    exs = textBox2.Text[le - 1];
                    o = "";
                    for (int i = 0; i < le - 1; i++)
                    {
                        o = o + textBox2.Text[i];
                    }
                    textBox2.Text = o;
                }
                value1 = Convert.ToDouble(textBox2.Text);
                value2 = Convert.ToDouble(textBox1.Text);
                if (exs == '+')
                {
                    result = value1 + value2;
                }
                if (exs == '-')
                {
                    result = value1 - value2;
                }
                if (exs == '*')
                {
                    result = value1 * value2;
                }
                if (exs == '/')
                {
                    result = value1 / value2;
                }
                textBox2.Text = Convert.ToString(result) + "-";
                textBox1.Text = "";
            }

        }
    }
}
